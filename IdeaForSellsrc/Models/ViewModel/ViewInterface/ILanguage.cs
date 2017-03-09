using IdeaForSellsrc.Models.ViewModel.Recources;
using System.Collections.Generic;

namespace IdeaForSellsrc.Models.ViewModel.ViewInterface
{
    interface ILanguage<T> where T: BaseResourceManager
    {
        T ResourceManager { get;}
    }
}
