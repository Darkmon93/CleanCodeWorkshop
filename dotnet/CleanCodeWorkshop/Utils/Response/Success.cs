
namespace CleanCodeWorkshop.Utils.Response
{
    public class Success : Result
    {
        public Success(string message) : base(success: true, message)
        {
        }
    }
}
