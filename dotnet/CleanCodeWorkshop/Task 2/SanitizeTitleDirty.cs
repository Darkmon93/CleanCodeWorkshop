
namespace CleanCodeWorkshop.Task_2
{
    public class SanitizeTitleDirty
    {
        //Sanitize title: remove brackets, dot and spaces
        public string Sanitize(string title)
        {
            title = title.Replace("[", string.Empty).Replace("]", string.Empty).Trim().TrimEnd('.');
            return title;
        }
    }
}
