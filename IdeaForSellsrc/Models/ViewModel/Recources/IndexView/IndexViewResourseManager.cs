using IdeaForSellsrc.Models.ViewModel.Recources.IndexView;
using IdeaForSellsrc.Models.ViewModel.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.ViewModel.Recources
{
    public sealed class IndexViewResourseManager: BaseResourceManager
    {
        public static List<string> IndexViewKey = new List<string>()
        {
            "LoginButton",
            "ViewCount",
            "RespondCount"
        };


        public IndexViewResourseManager(Language lang)
        {
            Type currentType = typeof(IndexView_en_USA);

            switch (lang)
            {
                case Language.en_USA:
                    currentType = typeof(IndexView_en_USA);
                    break;
                case Language.ru_RU:
                    currentType = typeof(IndexView_ru_RU);
                    break;
                case Language.ua_UA:
                    currentType = typeof(IndexView_ua_UA);
                    break;
            }

            tempMan = new global::System.Resources.ResourceManager(currentType);
        }

        global::System.Resources.ResourceManager tempMan;

        public override Dictionary<string, string> GetViewLiterals()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (string item in IndexViewResourseManager.IndexViewKey)
            {
                dict.Add(item, tempMan.GetString(item));
            }
            return dict;
        }
    }
}