using IdeaForSellsrc.Models.DataModel.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.DataModel.DataModel
{
    public class BaseAdvertisement:IUserRecord
    {
        #region Implement IUserRecordInterface
            public DateTime AddedDateTime { get; set; }
            public List<HashTag> HashTagList { get; set; }
            public int Id { get; set; }
            public int OwnerId { get; set; }
            public List<Commend> ReplyCommendList { get; set; }
        #endregion

        public string Tittle { get; set; }
        public string Description { get; set; }
        public MediaFile Media { get; set;}

    }
}