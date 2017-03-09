using IdeaForSellsrc.Models.ViewModel.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.ViewModel
{
    /// <summary>
    /// save object of the class after authorizaton of the user
    /// </summary>
    public class SessionUserData : ILocalozation, ISessionUser
    {
        /// <summary>
        /// IUserSessionInterface implement
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Ilocalization interface implement
        /// </summary>
        public Language Lang { get; set; }
        public string TimeZone { get; set; }
    }
}