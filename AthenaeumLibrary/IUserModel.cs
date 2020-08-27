using System;
using System.Collections.Generic;
using System.Text;

namespace AthenaeumLibrary
{
    public interface IUserModel
    {
        string Name { get; set; }
        string Notes { get; set; }
    }
}
