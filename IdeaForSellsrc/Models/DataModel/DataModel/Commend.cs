using IdeaForSellsrc.Models.DataModel.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models.DataModel.DataModel
{
    public class Commend: IUserRecord
    {
        #region Implement IUserRecordInterface
            public DateTime AddedDateTime { get; set; }
            public List<HashTag> HashTagList { get; set; }
            public int Id { get; set; }
            public int OwnerId { get; set; }
            public List<Commend> ReplyCommendList { get; set; }
        #endregion
        string Title { get; set; }
    }
}