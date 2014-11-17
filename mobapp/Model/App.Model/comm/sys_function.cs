namespace App.Model.comm
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.CodeDom.Compiler;
    using Eco.ObjectImplementation;
    using Eco.ObjectRepresentation;
    using Eco.Services;
    using Eco.Subscription;
    using Eco.UmlCodeAttributes;
    using Eco.UmlRt;
    using App.Model.comm;
    using Newtonsoft.Json;
    using System.IO;
    using System.Text;
    using System.Diagnostics;
    using System.Web;
    using System.Net;
    using Eco.Handles;
    
    public partial class sys_function
    {
        [UmlElement(Id = "53ded292-a8b5-4b54-903b-e0e9059f44e7")]
        public static string objecttojson(object item)
        {
            string json = JsonConvert.SerializeObject(item, Formatting.Indented, new JsonSerializerSettings() { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            return json;
        }

        [UmlElement(Id = "dc5eeb40-eff4-4534-94d8-12b17cdb1139")]
        public static int getclienttype()
        {
            string ps = getprocessname();
            if (ps.ToUpper().StartsWith("WEBDEV.WEBS"))
                return 0;//web client
            else
            {
                return 1;// pc client

            }
        }

        [UmlElement(Id = "ed8b646e-1cff-47f3-bdc2-ff5469844d41")]
        public string getextbykey(string key, string lng, string texttype)
        {
            return "no title";
        }

        [UmlElement(Id = "f1c4289f-7248-4b51-9ea8-6f2b4bda5940")]
        public user getcurruser()
        {
            if (this.current_userID == null)
                return null;
            user resultuser = null;
            if (sys_function.getclienttype() == 0)
            {
                resultuser = (HttpContext.Current.Session["CURR_USER"] as user);
            };
            if (sys_function.getclienttype() == 1)
            {
                sys_function sf = sys_function.getsysfunction(this.AsIObject().ServiceProvider);
                IExternalIdService ids = this.AsIObject().ServiceProvider.GetEcoService<IExternalIdService>();
                if (ids.ObjectForId(this.current_userID) != null)
                    resultuser = (ids.ObjectForId(sf.current_userID).AsObject as user);

            }
            return resultuser;
        }

        [UmlElement(Id = "8fff44bb-af53-45fc-bc8a-461ad498fbc0")]
        public static string getprocessname()
        {
            return Process.GetCurrentProcess().ProcessName;
        }

        [UmlElement(Id = "a28eeac5-ef36-47d2-b298-b731909c0bee")]
        public static sys_function getsysfunction(IEcoServiceProvider sp)
        {

            string strocl = "sys_function.oclSingleton";
            IOclService ocls = sp.GetEcoService<IOclService>();
            return ocls.Evaluate(strocl).AsObject as sys_function;
        }

        [UmlElement(Id = "73b19ffd-6726-4320-bdca-4759026334d6")]
        public static string getcurrIP()
        {
            string ipv4 = "";
            if (sys_function.getclienttype() == 1)
            {
                string name = Dns.GetHostName();
                IPHostEntry me = Dns.GetHostEntry(name);
                IPAddress[] ips = me.AddressList;
                foreach (IPAddress ip in ips)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                        continue;
                    ipv4 = ip.ToString();
                }
            }
            if (sys_function.getclienttype() == 0)
            {
                if (HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null) // 服务器， using proxy
                {
                    //得到真实的客户端地址
                    ipv4 = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();  // Return real client IP.
                }
                else//如果没有使用代理服务器或者得不到客户端的ip  not using proxy or can't get the Client IP
                {

                    // 得到服务端的地址
                    ipv4 = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString(); //While it can't get the Client IP, it will return proxy IP.
                }
            }

            return ipv4;
        }

        [UmlElement(Id = "1a91a58d-7b69-43ab-849b-6d6c3a5155c4")]
        public string idforobject(IEcoObject obj)
        {

            if (obj.IsNull())
                return "";
            IExternalIdService ids = this.AsIObject().ServiceProvider.GetEcoService<IExternalIdService>();
            return ids.IdForObject(obj);
        }

        [UmlElement(Id = "0bb74e00-b17b-46c3-bebe-b0cca2db9d30")]
        public object objectforid(string id)
        {
            IExternalIdService ids = this.AsIObject().ServiceProvider.GetEcoService<IExternalIdService>();
            return ids.ObjectForId(id);
        }

        [UmlElement(Id = "a280fcd3-5be6-4430-bbd9-a6a06ee762ac")]
        public user login(string username, string password)
        {
            user resultuser = null;
            IOclPsService oclps = this.AsIObject().ServiceProvider.GetEcoService<IOclPsService>();
            string str = "user.allInstances->select(username='" + username + "')";
            IEcoList<user> tmplist = oclps.Execute(str).GetAsEcoList<user>();

            if (tmplist.Count == 1 & tmplist[0] != null)
            {
                user tmpuser = tmplist[0];

                if (tmpuser.Password.Equals(password))
                {
                    resultuser = tmpuser;
                    tmpuser.setcurrentuser();
                }

            }
            return resultuser;

        }

        [UmlElement(Id = "4bcad1c6-f1f1-4de3-b2d3-33774fb9e2ea")]
        public void initsystem()
        {
            string strocl = "sys_param.allInstances";
            IOclService ocls = this.AsIObject().ServiceProvider.GetEcoService<IOclService>();
            if (ocls.Evaluate(strocl).GetAsIList<sys_param>().Count == 0)
            {
                sys_param newobj = new sys_param(this.AsIObject().ServiceProvider);
                newobj.name = "init state";
                newobj.value = "1";
                newobj.type = "system";
                //newobj = new sys_param(this.AsIObject().ServiceProvider); 

                this.AsIObject().ServiceProvider.GetEcoService<IPersistenceService>().UpdateDatabase(newobj);
            }
        }

        
    }
}