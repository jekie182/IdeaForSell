


namespace DBCore
{
    public class ModelResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public ModelResult()
        {
        }

        public ModelResult(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }

    public class ModelResult<T>
    {
        public T Result { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public ModelResult()
        {
        }

        public ModelResult(bool isSuccess, T result, string message)
        {
            Result = result;
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}