using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models
{
    public class Result
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T ModelResult { get; set; }
    }
}