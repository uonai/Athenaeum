using System;

namespace AthenaeumLibrary
{
    public class BookModel : IBookModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }

    }
}
