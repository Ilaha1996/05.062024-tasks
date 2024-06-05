namespace _05._06._2024_HelperLibrary
{
    public class Helper
    {
        public static string CreateBookCode(string Name, int id)
        {
            return $"{Name.ToUpper().Substring(0, 2)}+{id}";
        }

    }
}
