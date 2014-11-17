using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eco.Persistence;
using Mobapp.localEcoSpace;
using System.Text;
using Mobapp.webmvc.Models;
using System.Web.Security;
namespace Mobapp.webmvc.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            //ViewBag.Title = "manger db";
            return View();
        }
        public ActionResult Indexok()
        {
            ViewBag.Message = Session["ActionInfo"];
            return View();
        }
        public ActionResult Indexerror()
        {
            ViewBag.Message = Session["ErrorInfo"];
            return View();
        }
        public ActionResult Createdb()
        {
            l_PMP epmp = l_PMP.Instance;

            if (epmp.PersistenceMapper is PersistenceMapperDb)
            {
                (epmp.PersistenceMapper as IPersistenceMapperDb).CreateDatabaseSchema(epmp.GetTypeSystemService(true), new DefaultCleanPsConfig(true));
            }
            else
            {
                throw new InvalidOperationException("The PersistenceMapper is not a PersistenceMapperDb");
            }
            Session["ActionInfo"] = "create db ok";
            return RedirectToAction("Indexok");
        }
        public ActionResult Updatedb()
        {
            l_PMP epmp = l_PMP.Instance;
            IDBEvolutor evolutor;
            string[] executedStatements;
            StringBuilder logstr=new StringBuilder();
            
            if (epmp.PersistenceMapper is PersistenceMapperDb)
            {
                // (epmp.PersistenceMapper as IPersistenceMapperDb).(epmp.GetTypeSystemService(true), new DefaultCleanPsConfig(true));
                evolutor = (epmp.PersistenceMapper as IPersistenceMapperDb).GetEvolutor(epmp.GetTypeSystemService(true));
                try
                {
                    evolutor.CalculateScript();
                    var canExecute = true;
                    var errors = evolutor.GenerateErrors();
                    if (errors.Length > 0)
                    {                       
                        for (int i = 0; i < errors.Length; i++)
                        {
                            logstr.Append(errors[i]);
                        }
                        canExecute = false;
                    }
                    var warnings = evolutor.GenerateWarnings();
                    if (warnings.Length > 0)
                    {
                         for (int i = 0; i < warnings.Length; i++)
                        {
                            logstr.Append(warnings[i]);
                        }
                        //  canExecute = false;
                    }
                    if (!canExecute)
                    {
                        logstr.Append("can't execute");
                        Session["ErrorInfo"] = logstr.ToString();
                        return RedirectToAction("Indexerror");
                    };

                    string[] dbscript = evolutor.GenerateDbScript();
                    if (dbscript.Length > 0)
                    {
                       for (int i = 0; i < dbscript.Length; i++)
                        {
                            logstr.Append( dbscript[i]);
                        }
                        canExecute = false;
                    }
                    evolutor.ExecuteScript();
                    executedStatements = evolutor.GenerateExecutedStatements();
                    if (executedStatements.Length > 0)
                    {
                        string str;
                        for (int i = 0; i < executedStatements.Length; i++)
                        {
                            logstr.Append( executedStatements[i]);
                        }
                        canExecute = false;

                    }
                    else

                       logstr.Append( "[execute  info:]" + "No update needed.");

                }

                finally
                {

                    (epmp.PersistenceMapper as IPersistenceMapperDb).ReturnEvolutor(evolutor);

                }
            }
            else
            {
                Session["ErrorInfo"] = "The PersistenceMapper is not a PersistenceMapperDb";
                return RedirectToAction("Indexerror");
            }
            Session["ActionInfo"] = logstr.ToString();
            return RedirectToAction("Indexok");
        }
        public ActionResult Initdb()
        {

            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid &&model.UserName=="Admin" && model.Password == "1234")
            {
                loginset(model.RememberMe, model.UserName);
                return RedirectToAction("Index", "Admin");
               
            }
            return View(model);
        }
        protected void loginset(bool RememberMe, string strUserName)
        {
            Session["CURR_USER"] = strUserName;
            FormsAuthentication.SetAuthCookie(strUserName, true);
            if (RememberMe)
            {
                HttpCookie lcookie = Response.Cookies[FormsAuthentication.FormsCookieName];
                int Inttimeout = Convert.ToInt32(System.Configuration.ConfigurationSettings.AppSettings.Get("LoginTimeout"));
                lcookie.Expires = DateTime.Now.AddMinutes(Inttimeout);

                Session.Timeout = Inttimeout;
            }
            HttpCookie logintypecookie = new HttpCookie("clogintype");
            logintypecookie.Values.Add("logintype", "adminlogin");
            Response.Cookies.Add(logintypecookie);
        }
    }
}
