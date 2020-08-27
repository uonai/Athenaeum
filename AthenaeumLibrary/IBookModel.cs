using System;
using System.Collections.Generic;
using System.Text;

namespace AthenaeumLibrary
{
    public interface IBookModel
    {
        string Title { get; set; }
        string Author { get; set; }
        int Rating { get; set; }
        string Review { get; set; }
        string Notes { get; set; }
        string Category { get; set; }

    }
}
