
namespace CleanCodeWorkshop.Utils.Response
{
    public class Failure : Result
    {
        public Failure(string message) : base(success: false, message)
        {
        }
    }
}
