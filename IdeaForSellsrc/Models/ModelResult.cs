using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaForSellsrc.Models
{
    public class ModelResult<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }

        public ModelResult (DBCore.ModelResult<T> result)
        {
            IsSuccess = result.IsSuccess;
            Message = result.Message;
            Result = result.Result;
        }
        public ModelResult()
        { }
    }

    public class ModelResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }
    }


}