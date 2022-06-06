using CleanCodeWorkshop.Utils;

namespace CleanCodeWorkshop.Task_2
{
    public class SanitizeTitleClean
    {
        public string Sanitize(string title)
        {
            var titleSanitizer = new Sanitizer(title);

            return titleSanitizer
                .RemoveBrackets()
                .TrimWhitespaces()
                .TrimDotFromEnd()
                .GetTitle();
        }
    }
}
