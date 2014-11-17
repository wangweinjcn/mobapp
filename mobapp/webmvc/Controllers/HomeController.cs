using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Model.comm;
using Mobapp.localEcoSpace;
using Eco.Handles;
using Eco.Linq;
using Eco.MVC;
using Eco.Services;
using Eco.ObjectRepresentation;
using Eco.Interfaces;
namespace Mobapp.webmvc.Controllers
{
    public class HomeController : EcoController<Mobapp.localEcoSpace.l_EcoSpace>
    {
       
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult menutest()
        {
            IEnumerable<App.Model.comm.menugroup> menulist;
            //menulist = (from x in EcoSpace.PSQuery<menugroup>() orderby (x.name) select (x)).Take(15).ToList();
            string oclstr = "menugroup.allInstances";
          menulist=  EcoSpace.GetEcoService<IOclService>().Evaluate(oclstr).GetAsIList<menugroup>();

             return View("menutest", menulist);
        }
    }
}
