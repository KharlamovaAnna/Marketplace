using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desctiption { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        // image url это че как

        public virtual ICollection<Favourite> Favourites { get; set; }
        public virtual ICollection<Hidden_Product> Hidden_Products { get; set; }
    }
}
