using System;
using System.Collections.Generic;

namespace Project.Classes
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password_Hash { get; set; }
        public string Name { get; set; }
        public DateTime Created_At { get; set; }

        public virtual ICollection<Survey> Surveys { get; set; }
        public virtual ICollection<Users_answer> User_answers { get; set; }
        public virtual ICollection<Favourite> Favourites { get; set; }
        public virtual ICollection<Hidden_Product> Hidden_Products { get; set; }
    }
}
