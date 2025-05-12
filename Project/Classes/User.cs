using System;

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
