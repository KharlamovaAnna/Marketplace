using Project.Classes;
using System.Windows.Forms;
using System;
using System.Linq;


namespace Project.Forms
{
    /// <summary>
    /// класс для выбора бренда
    /// </summary>
    public partial class ChooseBrand : Form
    {
        private int userID;
        private string selectedCategory;

        public ChooseBrand(int userID, string selectedCategory)
        {
            InitializeComponent();
            this.userID = userID;
            this.selectedCategory = selectedCategory;
            LoadBrands();
        }

        private void LoadBrands()
        {
            using (var db = new Classes.AppContext())
            {
                var brands = db.Products
                    .Where(p => p.Category == selectedCategory)
                    .Select(p => p.Brand)
                    .Distinct()
                    .ToList();

                foreach (var brand in brands)
                {
                    checkedListBoxBrands.Items.Add(brand);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkedListBoxBrands.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите бренд");
                return;
            }

            string selectedBrand = checkedListBoxBrands.CheckedItems[0].ToString();
            SaveUserChoice(selectedBrand);

            var productForm = new ChooseItem(userID, selectedCategory, selectedBrand);
            productForm.Show();
            this.Hide();
        }

        private void SaveUserChoice(string brand)
        {
            using (var db = new Classes.AppContext())
            {
                var option = db.Options.FirstOrDefault(o => o.Text == brand);
                if (option != null)
                {
                    db.User_answers.Add(new Users_answer
                    {
                        User_ID = userID,
                        Option_ID = option.ID,
                    });
                    db.SaveChanges();
                }
            }
        }
    }
}