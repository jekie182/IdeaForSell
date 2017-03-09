using IdeaForSellsrc.Models.ViewModel.Recources.LoginView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.ViewModel.ViewModel
{
    public class LoginViewModel: BaseView<LoginViewResourceManager>
    {
        public LoginViewModel(SessionUserData data, LoginViewResourceManager manager) : base(data,  manager)
        {
        }
    }
}