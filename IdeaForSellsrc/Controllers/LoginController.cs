using IdeaForSellsrc.Models.ViewModel;
using IdeaForSellsrc.Models.ViewModel.Recources.LoginView;
using IdeaForSellsrc.Models.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdeaForSellsrc.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            //by default is is UA
            //but it chanch after login after login we are take it data from session
            SessionUserData ssdata = new SessionManager().GetSessionUserData(Session);
            LoginViewModel model = new LoginViewModel(ssdata, new LoginViewResourceManager(ssdata.Lang));

            return View("Login", model);
        }
    }
}