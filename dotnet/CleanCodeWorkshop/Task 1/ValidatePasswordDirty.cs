using CleanCodeWorkshop.Utils.Response;
using System.Text.RegularExpressions;

namespace CleanCodeWorkshop.Task_1
{
    public class ValidatePasswordDirty
    {
        public Result ValidateStrength(string password)
        {
            if(string.IsNullOrEmpty(password))
            {
                return new Result(success: false, message: "Password cannot be empty");
            } 
            else
            {
                if(password.Length < 8)
                {
                    return new Result(success: false, message: "Password must be at least 8 characters");
                }
                else
                {
                    var hasSpecialCharacter = false;
                    foreach(var character in password)
                    {
                        if(!char.IsLetterOrDigit(character))
                        {
                            hasSpecialCharacter = true;
                        }
                    }

                    if(!hasSpecialCharacter)
                    {
                        return new Result(success: false, message: "Password must contain at least one special character");
                    }
                    else
                    {
                        if (!Regex.Match(password, @".*\d+.*").Success)
                        {
                            return new Result(success: false, message: "Password must contains at least one digit");
                        }
                        else
                        {
                            return new Result(success: true, message: "Password is strong enough");
                        }
                    }
                }
            }
        }
    }
}
