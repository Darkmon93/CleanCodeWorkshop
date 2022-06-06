
namespace CleanCodeWorkshop.Utils
{
    public class Sanitizer
    {
        private string title;

        public Sanitizer(string title)
        {
            this.title = title;
        }

        public Sanitizer RemoveBrackets()
        {
            //TODO ...
            return this;
        }

        public Sanitizer TrimDotFromEnd()
        {
            //TODO ...
            return this;
        }

        public Sanitizer TrimWhitespaces()
        {
            //TODO ...
            return this;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
