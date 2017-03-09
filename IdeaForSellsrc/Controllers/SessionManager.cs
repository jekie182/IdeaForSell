using IdeaForSellsrc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IdeaForSellsrc.Controllers
{
    public sealed class SessionManager
    {
        public static string CurrentUserSessionData = "CurrentUserSessionData";
        public  SessionUserData GetSessionUserData(HttpSessionStateBase session)
        {
            var data = session[CurrentUserSessionData];
            if (data == null)
            {
                return new SessionUserData()
                {
                    Lang = Language.en_USA,
                    TimeZone = "+0"
                };
            }
            else return data as SessionUserData;
        }

        public void SetSessionUserData(SessionUserData data, HttpSessionStateBase session)
        {
            session[CurrentUserSessionData] = data;
        }
    }
}