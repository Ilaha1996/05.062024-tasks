namespace MyHelperLibrary
{
    public static class Helper
    {
        public static string CreateBookCode(string BookName, int Id)
        {
            return $"{BookName.ToUpper().Substring(0, 2)}+{Id}";
        }

    }
}
