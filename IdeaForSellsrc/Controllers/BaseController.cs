using IdeaForSellsrc.Models;
using IdeaForSellsrc.Models.DataModel.RequestModelFromView;
using IdeaForSellsrc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace IdeaForSellsrc.Controllers
{
    public class BaseController : Controller
    {
        public ActionResult TranslateMessage(ref ModelResult<List<string>> messages, SessionUserData data)
        {
            if (messages.Result != null && messages.Result.Count > 0)
            {
                Type currentType = typeof(ValidationMessage_en_USA);

                switch (data.Lang)
                {
                    case Language.en_USA:
                        currentType = typeof(ValidationMessage_en_USA);
                        break;
                    case Language.ru_RU:
                        currentType = typeof(ValidationMessage_ru_RU);
                        break;
                    case Language.ua_UA:
                        currentType = typeof(ValidationMessage_ua_UA);
                        break;
                }

                var tempMan = new global::System.Resources.ResourceManager(currentType);

                for (int i =0; i < messages.Result.Count; i++)
                {
                    messages.Result[i] = tempMan.GetString(messages.Result[i]);
                }
            }
            return Json(new JavaScriptSerializer().Serialize(messages));
        }
    }
}