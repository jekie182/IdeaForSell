using IdeaForSellsrc.Models;
using IdeaForSellsrc.Models.ViewModel;
using IdeaForSellsrc.Models.ViewModel.Recources;
using IdeaForSellsrc.Models.ViewModel.ViewModel;
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
            SessionManager session = new SessionManager();
            session.SetSessionUserData(
                new SessionUserData()
                    {
                        Id = "1",
                        Lang = Language.ua_UA,
                        TimeZone = "+2"
                     }, Session);

            SessionUserData ssdata = session.GetSessionUserData(Session);
            //by default is is UA
            //but it chanch after login after login we are take it data from session
            IndexViewModel model = new IndexViewModel(ssdata, new IndexViewResourseManager(ssdata.Lang));
            return View("Index", model);
        }
    }
}