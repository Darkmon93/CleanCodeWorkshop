using System;

namespace CleanCodeWorkshop.Utils.Response
{
    public class Result
    {
        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }

        public override bool Equals(object obj)
        {
            var result = obj as Result;

            if (obj == null)
            {
                return false; ;
            }

            return Success == result.Success && Message == result.Message;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Success, Message);
        }
    }
}
