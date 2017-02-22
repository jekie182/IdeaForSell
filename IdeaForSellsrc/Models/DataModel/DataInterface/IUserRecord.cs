using IdeaForSellsrc.Models.DataModel.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaForSellsrc.Models.DataModel.DataInterface
{
    interface IUserRecord
    {
        int Id { get; set; }
        //id of the user who add that commend
         int OwnerId { get; set; }
         DateTime AddedDateTime { get; set; }
         List<HashTag> HashTagList { get; set; }
         List<Commend> ReplyCommendList { get; set; }
    }
}
