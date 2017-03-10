using IdeaForSellsrc.Models;
using IdeaForSellsrc.Models.BussinessModel.FunctionalModel;
using IdeaForSellsrc.Models.BussinessModel.RepoModel;
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
        private SessionManager sessionManager =new SessionManager();
        public ActionResult Registration()
        {
            SessionUserData ssdata = sessionManager.GetSessionUserData(Session);
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
                //LoginAlreadyExist
                ModelResult result = new RegistrationManager().CreateNewUser(regUser.UserName, regUser.Password);
                if(!result.IsSuccess)
                    return TranslateMessage(ref result, sessionManager.GetSessionUserData(Session));

                UserInfoData userModel = (UserInfoData)result.Result;
                Session[UserIdKey] = userModel?.UserId;
                
                return View("Account");
            }
            else
            {
                return TranslateMessage(ref validResult, sessionManager.GetSessionUserData(Session));
            }
        }
    }
}