using IdeaForSellsrc.Models.ViewModel.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdeaForSellsrc.Models.ViewModel.Recources;

namespace IdeaForSellsrc.Models.ViewModel
{
    public class BaseView<T> :  SessionUserData, ILanguage<T> where T : BaseResourceManager
    {
        public BaseView() { }
        public BaseView(SessionUserData data, T manager)
        {
            Id = data.Id;
            Lang = data.Lang;
            TimeZone = data.TimeZone;
            resourceManager = manager;
            listOfLiterals = resourceManager.GetViewLiterals();
        }

        /// <summary>
        /// ILanguage Interface Implement
        /// </summary>
        public Dictionary<string, string> ListOfLiterals { get
            {
                return listOfLiterals;
            }
        }

        private T resourceManager;
        private Dictionary<string, string> listOfLiterals;
        public T ResourceManager
        {
            get
            {
                return resourceManager;
            }

            set
            {
                resourceManager = value;
            }
        }
    }
}