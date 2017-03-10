using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdeaForSellsrc.Models.DataModel.RequestModelFromView.Interface;

namespace IdeaForSellsrc.Models.DataModel.RequestModelFromView.RegistrationView
{
    public class RegistrationModel: BaseValidator, IValidationModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ModelResult<List<string>> Validate()
        {
            var result = new ModelResult<List<string>>()
            {
                Result = new List<string>(),
                IsSuccess = true,
            };
            if (string.IsNullOrEmpty(Password))
                result.Result.Add("PasswordRequired");
            if(Password?.Length > 50)
                result.Result.Add("MaxPasswordLength");
            if (ConfirmPassword != Password)
                result.Result.Add("NotConFirmedPassword");
            if (string.IsNullOrEmpty(ConfirmPassword))
                result.Result.Add("ConfirmPasswordRequired");
            if (ConfirmPassword?.Length > 50)
                result.Result.Add("MaxPasswordLength");
            if (string.IsNullOrEmpty(UserName))
                result.Result.Add("UserIdRequired");
            if (UserName?.Length > 50)
                result.Result.Add("MaxLengthOfUserId");

            if (result.Result.Count > 0)
                result.IsSuccess = false;
            return result;   
        }
    }
}