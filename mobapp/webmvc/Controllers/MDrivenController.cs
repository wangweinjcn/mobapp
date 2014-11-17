using System;
using System.Collections.Generic;
using System.Linq;
using App.Model.comm;
using Mobapp.localEcoSpace;
using System.Web;
using System.Web.Mvc;
using Eco.Handles;
using Eco.Linq;
using Eco.MVC;
using Eco.Services;
using Eco.ObjectRepresentation;
using Eco.Interfaces;

namespace MvcApplication1.Controllers
{
    public class MDrivenController : EcoController<Mobapp.localEcoSpace.l_EcoSpace>
    {

        
        public ActionResult Index()
        {
            var z = (from x in EcoSpace.PSQuery<sys_param>() orderby (x.name) select (x)).Take(15).ToList();
            return View(z);
        }

        public ActionResult Create()
        {
            var c1 = new sys_param(EcoSpace);
            c1.name = "Created " + DateTime.Now.ToString();

            UpdateDatabase();
           
            return RedirectToAction("Index");
        }


        public ActionResult Edit(string id)
        {
            var x = ObjectForId(id).GetValue<sys_param>();
          if (x != null )
            return View("Edit",x);
          return View();
        }

        [HttpPost]
        public ActionResult Edit(string id, sys_param c1)
        {
            try
            {
                var x = ObjectForId(id).GetValue<sys_param>();
              if (x != null )
              {
                ApplyValues(c1, x);
                UpdateDatabase();
              }
              return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
