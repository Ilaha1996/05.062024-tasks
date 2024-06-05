
namespace _05._06._2024
{
    public class Book
    {
        private static int counter;
        private int _id;
        private string _name;
        private string _authorName;
        private int _pageCount;
        private string _code;
        public int Id { get { return _id; } private set { _id = value; } }
        public Book(string name)
        {
            _id = ++counter;
            _name = name;
            _code = _2024_HelperLibrary.Helper.CreateBookCode(_name, _id);
            
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                _code = _2024_HelperLibrary.Helper.CreateBookCode(_name, _id);
            }
        }
        public string AuthorName { get { return _authorName; } set { _authorName = value; } }
        public int PageCount { get { return _pageCount; } set { _pageCount = value; } }
        public string Code { get { return _code; } }
    }
}
