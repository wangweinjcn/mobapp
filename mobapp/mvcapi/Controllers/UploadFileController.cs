using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Net.Http.Formatting;
using System.Configuration;
namespace Mobapp.mvcapi.Controllers
{
   
    public class UploadFileController : ApiController
    {
        /// <summary> 
        /// 将 Stream 写入文件 
        /// </summary> 
        private void StreamToFile(Stream stream, string fileName)
        {
            //isAlreadyRunning();
            //=========
            FileStream fs = null;
            BinaryWriter bw = null;
            try
            {
                // 把 Stream 转换成 byte[] 
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                // 设置当前流的位置为流的开始 
                stream.Seek(0, SeekOrigin.Begin);

                // 把 byte[] 写入文件 

                fs = new FileStream(fileName, FileMode.Create);
                bw = new BinaryWriter(fs);
                bw.Write(bytes);
            }
            catch (Exception ex)
            {
               // Alert.Show(ex.Message);
                throw new Exception("can't create file:"+ex.Message);
                
            }
            finally
            {
                bw.Close();
                fs.Close();
            }
        }
        [HttpPost]
        public Task<Hashtable> ImgUpload()
        {
            // 检查是否是 multipart/form-data
            if (!Request.Content.IsMimeMultipartContent("form-data"))
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            //文件保存目录路径
            string SaveTempPath = "~/SayPlaces/" + "/SayPicTemp/";
            String dirTempPath = System.Web.Hosting.HostingEnvironment.MapPath(SaveTempPath);
            // 设置上传目录
            var provider = new MultipartFormDataStreamProvider(dirTempPath);
            //var queryp = Request.GetQueryNameValuePairs();//获得查询字符串的键值集合
            var task = Request.Content.ReadAsMultipartAsync(provider).
                ContinueWith<Hashtable>(o =>
                {
                    Hashtable hash = new Hashtable();
                    hash["error"] = 1;
                    hash["errmsg"] = "上传出错";
                    var file = provider.FileData[0];//provider.FormData
                    string orfilename = file.Headers.ContentDisposition.FileName.TrimStart('"').TrimEnd('"');
                    FileInfo fileinfo = new FileInfo(file.LocalFileName);
                    //最大文件大小
                    int maxSize = 10000000;
                    if (fileinfo.Length <= 0)
                    {
                        hash["error"] = 1;
                        hash["errmsg"] = "请选择上传文件。";
                    }
                    else if (fileinfo.Length > maxSize)
                    {
                        hash["error"] = 1;
                        hash["errmsg"] = "上传文件大小超过限制。";
                    }
                    else
                    {
                        string fileExt = orfilename.Substring(orfilename.LastIndexOf('.'));
                        //定义允许上传的文件扩展名
                        String fileTypes = "gif,jpg,jpeg,png,bmp";
                        if (String.IsNullOrEmpty(fileExt) || Array.IndexOf(fileTypes.Split(','), fileExt.Substring(1).ToLower()) == -1)
                        {
                            hash["error"] = 1;
                            hash["errmsg"] = "上传文件扩展名是不允许的扩展名。";
                        }
                        else
                        {
                            String ymd = DateTime.Now.ToString("yyyyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                            String newFileName = DateTime.Now.ToString("yyyyMMddHHmmss_ffff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                            fileinfo.CopyTo(Path.Combine(dirTempPath, newFileName + fileExt), true);
                            fileinfo.Delete();
                            hash["error"] = 0;
                            hash["errmsg"] = "上传成功";
                        }
                    }
                    return hash;
                });
            return task;
        }
        [HttpPost]
        public Task<HttpResponseMessage> PostFormData()
        {
            // Check if the request contains multipart/form-data.
            // 检查该请求是否含有multipart/form-data
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }


            var streamProvider = new MultipartMemoryStreamProvider();

            var task = Request.Content.ReadAsMultipartAsync(streamProvider).
                ContinueWith<HttpResponseMessage>(t =>
                {
                    if (t.IsFaulted || t.IsCanceled)
                    {
                        Request.CreateErrorResponse(HttpStatusCode.InternalServerError, t.Exception);
                    }


                    foreach (var bodypart in streamProvider.Contents)
                    {
                       // Trace.WriteLine(file.Headers.ContentDisposition.FileName);
                      //  Trace.WriteLine("Server file path: " + file.LocalFileName);
                        string name;
                        name = bodypart.Headers.ContentDisposition.Name;
                       
                        if (bodypart.Headers.ContentDisposition.FileName != null)
                        {
                            string filePath = bodypart.Headers.ContentDisposition.FileName;
                            if (filePath.StartsWith(@"""") && filePath.EndsWith(@""""))
                                filePath = filePath.Substring(1, filePath.Length - 2);
                            string str_filename = Path.GetFileName(filePath);
                           // string rootdir = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data");
                            string rootdir = ConfigurationSettings.AppSettings["image_path"].ToString(); 
                            var ntask = bodypart.ReadAsStreamAsync().ContinueWith<HttpResponseMessage>(nt =>
                            {
                                if (nt.IsFaulted || nt.IsCanceled)
                                {
                                    Request.CreateErrorResponse(HttpStatusCode.InternalServerError, t.Exception);
                                }
                                var filesm = nt.Result;
                                StreamToFile(filesm, rootdir + Path.DirectorySeparatorChar + str_filename);
                         
                                return Request.CreateResponse(HttpStatusCode.OK);
                            });
                           

                        }
                        else
                        {
                           // string val =  bodypart.ReadAsStringAsync();
                          
                        }
                      
                        
                    }
                    return Request.CreateResponse(HttpStatusCode.OK);
                });

            return task;
        }
     /* 
      * this is dotnet4.5 function
        [HttpPost]
        public async void PostMultiFile()
        {
            StringBuilder sb = new StringBuilder();
            HttpContent content = Request.Content;
            if (content.IsMimeMultipartContent())
            {
                IEnumerable<HttpContent> bodyparts = (await content.ReadAsMultipartAsync()).Contents ;
                foreach (var bodypart in bodyparts)
                {
                    string name;
                    name = bodypart.Headers.ContentDisposition.Name;
                    sb.Append(name + ":");
                    if (bodypart.Headers.ContentDisposition.FileName!=null)
                    {
                        string filePath = bodypart.Headers.ContentDisposition.FileName;
                        if (filePath.StartsWith(@"""") && filePath.EndsWith(@""""))
                            filePath = filePath.Substring(1, filePath.Length - 2);
                        string str_filename = Path.GetFileName(filePath);
                        Stream stream = await bodypart.ReadAsStreamAsync();
                        StreamReader reader = new StreamReader(stream);
                        string root = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data");
                        StreamToFile(stream, root + Path.DirectorySeparatorChar    + str_filename);
                        sb.Append(reader.ReadToEnd());
                        
                        sb.Append("----");
                    }
                    else
                    {
                        string val = await bodypart.ReadAsStringAsync();
                        sb.Append(val);
                        sb.Append("----");
                    }
                }
            }
            else
            {
                JsonObject jsonValue = await content.ReadAsAsync<JsonObject>();
                foreach (var x in jsonValue)
                {
                    sb.Append(x.Key);
                    if ( x.Value.JsonType==JsonType.String)
                    {
                        sb.Append(x.Value.Cast<string>());
                    }
                }
            }
        }
      * */
        public class MyFormDataStreamProvider : MultipartFormDataStreamProvider
        {
            public MyFormDataStreamProvider(string path)
                : base(path)
            { }
            
            public override Stream GetStream(HttpContent parent, System.Net.Http.Headers.HttpContentHeaders headers)
            {
                // restrict what images can be selected
                var extensions = new[] { "png", "gif", "jpg" };
                var filename = headers.ContentDisposition.FileName.Replace("\"", string.Empty);

                if (filename.IndexOf('.') < 0)
                    return Stream.Null;

                var extension = filename.Split('.').Last();

                return extensions.Any(i => i.Equals(extension, StringComparison.InvariantCultureIgnoreCase))
                           ? base.GetStream(parent, headers)
                           : Stream.Null;

            }

            public override string GetLocalFileName(System.Net.Http.Headers.HttpContentHeaders headers)
            {
                // override the filename which is stored by the provider (by default is bodypart_x)
               
                string oldfileName = headers.ContentDisposition.FileName.Replace("\"", string.Empty);
                string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(oldfileName);

                return newFileName;
            }
        }
    }
}
