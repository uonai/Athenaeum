using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AthenaeumLibrary
{
    public class UserModel : IUserModel
    {
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}
