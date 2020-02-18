using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayTest.Models
{
    public class UserDTO
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool StateAuth { get; set; }
    }
}