using CleanCodeWorkshop.Utils.Response;

namespace CleanCodeWorkshop.Task_1
{
    public class ValidatePasswordClean
    {
        //TODO: Set appropriate value
        private const int MinimalPasswordLength = 0;
        public Result ValidateStrength(string password)
        {
            //TODO: Check that the password is empty or null and if so, return an error
            
            if(password.Length < MinimalPasswordLength)
            {
                return new Failure(message: "Password must be at least 8 characters");
            }

            if(!HasSpecialCharacter(password))
            {
                return new Failure(message: "Password must contain at least one special character");
            }

            if(!HasDigit(password))
            {
                return new Failure(message: "Password must contains at least one digit");
            }

            return new Success(message: "Password is strong enough");
        }

        private bool HasDigit(string password)
        {
            // TODO implement method

            return true;
        }

        private bool HasSpecialCharacter(string password)
        {
            // TODO: implement method

            return true;
        }
    }
}
