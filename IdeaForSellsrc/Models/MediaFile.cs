using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models
{
    public class MediaFile
    {
        public string FileName { get; set; }
        public object FileData { get; set; }
        public MediaType FileType { get; set; }
    }
}