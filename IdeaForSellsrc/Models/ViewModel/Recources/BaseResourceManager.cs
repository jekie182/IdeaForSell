using IdeaForSellsrc.Models.ViewModel.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.ViewModel.Recources
{
    public class BaseResourceManager : IResourseManager
    {
        /// <summary>
        /// base class has no realization of those methods
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<string, string> GetViewLiterals()
        {
            throw new NotImplementedException();
        }
    }
}