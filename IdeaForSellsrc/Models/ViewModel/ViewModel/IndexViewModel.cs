using IdeaForSellsrc.Models.ViewModel.Recources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.ViewModel.ViewModel
{
    public class IndexViewModel: BaseView<IndexViewResourseManager>
    {
        public IndexViewModel(SessionUserData data, IndexViewResourseManager manager) : base(data,  manager)
        {

        }
    }
}