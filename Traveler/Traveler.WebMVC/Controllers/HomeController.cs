using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traveler.Domain;
using Traveler.WebMVC.Code;
using Traveler.WebMVC.Models;

namespace Traveler.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var user = FakeObjects.GetUser();
            var model = new TestModel();
            model.User = user;

            return View(model);
        }

    }
}
