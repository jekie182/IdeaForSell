using IdeaForSellsrc.Models;
using IdeaForSellsrc.Models.DataModel.RequestModelFromView.RegistrationView;
using IdeaForSellsrc.Models.ViewModel;
using IdeaForSellsrc.Models.ViewModel.Recources.RegistrationView;
using IdeaForSellsrc.Models.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdeaForSellsrc.Controllers
{
    /// <summary>
    /// Provided methods to registation new user on IdeaForSell
    /// need to create some method to registation from social and so on
    /// </summary>
    public class RegistrationController : BaseController
    {
        public ActionResult Registration()
        {
            SessionUserData ssdata = new SessionManager().GetSessionUserData(Session);
            RegistrationViewModel model = new RegistrationViewModel(ssdata, new RegistrationViewResourceManager(ssdata.Lang));
            return View("Registration", model);
        }

        [HttpPost]
        public ActionResult CreateAnAccount(RegistrationModel regUser)
        {
            //if object is valid than try create new user
            ModelResult<List<string>> validResult = regUser.Validate();
            if (validResult.IsSuccess)
            {

                return View("Account");
            }
            else
            {
                return TranslateMessage(ref validResult, new SessionManager().GetSessionUserData(Session));
            }
        }
    }
}