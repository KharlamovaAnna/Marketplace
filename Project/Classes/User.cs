using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password_Hash { get; set; }
        public string Name { get; set; }
        public DateTime Created_At { get; set; }

    }
}
