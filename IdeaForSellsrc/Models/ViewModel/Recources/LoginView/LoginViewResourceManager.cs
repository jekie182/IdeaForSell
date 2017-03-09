using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.ViewModel.Recources.LoginView
{
    public class LoginViewResourceManager: BaseResourceManager
    {
        public static List<string> IndexViewKey = new List<string>()
        {
            "SignInNow",
            "UserID",
            "Password",
            "SingInButton",
            "SinInAsSocialNetwork",
            "HaveAnAccount",
            "CreateAnAccount",
            "ForgotPassword",
            "EnterYourEmail",
            "CancelButton",
            "SubmitButton",
            "Tittle"
        };


        public LoginViewResourceManager(Language lang)
        {
            Type currentType = typeof(LoginView_en_USA);

            switch (lang)
            {
                case Language.en_USA:
                    currentType = typeof(LoginView_en_USA);
                    break;
                case Language.ru_RU:
                    currentType = typeof(LoginView_ru_RU);
                    break;
                case Language.ua_UA:
                    currentType = typeof(LoginView_ua_UA);
                    break;
            }

            tempMan = new global::System.Resources.ResourceManager(currentType);
        }

        global::System.Resources.ResourceManager tempMan;

        public override Dictionary<string, string> GetViewLiterals()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string item in LoginViewResourceManager.IndexViewKey)
            {
                dict.Add(item, tempMan.GetString(item));
            }
            return dict;
        }    
    }
}