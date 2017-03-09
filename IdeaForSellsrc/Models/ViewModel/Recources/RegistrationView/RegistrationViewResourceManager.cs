using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.ViewModel.Recources.RegistrationView
{
    public class RegistrationViewResourceManager: BaseResourceManager
    {
        public static List<string> IndexViewKey = new List<string>()
        {
            "Registration",
            "UserID",
            "Password",
            "ConfirmPassword",
            "SinInAsSocialNetwork",
            "Email",
            "CREATEACCOUNTButton",
            "HaveAccount",
            "LoginButton",
            "Tittle"
        };


        public RegistrationViewResourceManager(Language lang)
        {
            Type currentType = typeof(RegistrationView_en_USA);

            switch (lang)
            {
                case Language.en_USA:
                    currentType = typeof(RegistrationView_en_USA);
                    break;
                case Language.ru_RU:
                    currentType = typeof(RegistrationView_ru_RU);
                    break;
                case Language.ua_UA:
                    currentType = typeof(RegistrationView_ua_UA);
                    break;
            }

            tempMan = new global::System.Resources.ResourceManager(currentType);
        }

        global::System.Resources.ResourceManager tempMan;

        public override Dictionary<string, string> GetViewLiterals()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string item in RegistrationViewResourceManager.IndexViewKey)
            {
                dict.Add(item, tempMan.GetString(item));
            }
            return dict;
        }
    }
}