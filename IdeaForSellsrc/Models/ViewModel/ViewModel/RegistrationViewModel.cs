using IdeaForSellsrc.Models.ViewModel.Recources.RegistrationView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.ViewModel.ViewModel
{
    public class RegistrationViewModel: BaseView<RegistrationViewResourceManager>
    {
        public RegistrationViewModel(SessionUserData data, RegistrationViewResourceManager manager) : base(data,  manager)
        {
        }
    }
}