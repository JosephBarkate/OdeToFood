using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        [Authorize]
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);
            return Content(name);
           // return RedirectToAction("Index", "Home", new { name = name });
        }


    }
}
