using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using IdeaForSellsrc.Models.DataModel.RequestModelFromView.Interface;

namespace IdeaForSellsrc.Models.DataModel.RequestModelFromView.RegistrationView
{
    public class RegistrationModel: BaseValidator, IValidationModel
    {
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [MaxLength(20)]
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
            if(Password?.Length > 20)
                result.Result.Add("MaxPasswordLength");
            if (ConfirmPassword != Password)
                result.Result.Add("NotConFirmedPassword");
            if (string.IsNullOrEmpty(ConfirmPassword))
                result.Result.Add("ConfirmPasswordRequired");
            if (ConfirmPassword?.Length > 20)
                result.Result.Add("MaxPasswordLength");
            if (string.IsNullOrEmpty(UserName))
                result.Result.Add("UserIdRequired");
            if (UserName?.Length > 20)
                result.Result.Add("MaxLengthOfUserId");
            if (string.IsNullOrEmpty(Email))
                result.Result.Add("EmailRequired");
            if (!IsValidEmail(Email))
                result.Result.Add("EmailIsNotCorrect");

            if (result.Result.Count > 0)
                result.IsSuccess = false;
            return result;   
        }
    }
}