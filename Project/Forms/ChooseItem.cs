using System;
using System.Windows.Forms;
using System.Linq;

namespace Project.Forms
{
    public partial class ChooseItem : Form
    {
        private int userID;
        private string selectedCategory;
        private string selectedBrand;

        public ChooseItem(int userID, string selectedCategory, string selectedBrand)
        {
            InitializeComponent();
            this.userID = userID;
            this.selectedCategory = selectedCategory;
            this.selectedBrand = selectedBrand;
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (var db = new Classes.AppContext())
            {
                var products = db.Products
                    .Where(p => p.Category == selectedCategory && p.Brand == selectedBrand)
                    .Take(4)
                    .ToList();

                foreach (var product in products)
                {
                    checkedListBoxItems.Items.Add(product.Name);
                }
            }
        }

        private void SaveUserChoice(string productName)
        {
            using (var db = new Classes.AppContext())
            {
                var product = db.Products.FirstOrDefault(p => p.Name == productName);
                if (product != null)
                {
                    db.Favourites.Add(new Classes.Favourite
                    {
                        User_ID = userID,
                        Product_ID = product.ID
                    });
                    db.SaveChanges();
                }
            }
        }

       
    }
}

