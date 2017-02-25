using IdeaForSellsrc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdeaForSellsrc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TestModel.Execute();
            return View();
        }
    }
}