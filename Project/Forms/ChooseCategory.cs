using Project.Classes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project.Forms
{
    /// <summary>
    /// класс выбора категории
    /// </summary
    public partial class ChooseCategory : Form
    {
        private int userID;

        public ChooseCategory(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadCategories();
        }

        private void LoadCategories()
            {
                using (var db = new Classes.AppContext())
                {
                    var categories = db.Products
                        .Select(p => p.Category)
                        .Distinct()
                        .ToList();

                    foreach (var category in categories)
                    {
                        checkedListBoxCategories.Items.Add(category);
                    }
                }
            }

            private void btnNext_Click(object sender, EventArgs e)
            {
                if (checkedListBoxCategories.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Выберите категорию");
                    return;
                }

                string selectedCategory = checkedListBoxCategories.CheckedItems[0].ToString();
                SaveUserChoice(selectedCategory);

                var brandForm = new ChooseBrand(userID, selectedCategory);
                brandForm.Show();
                this.Hide();
            }

            private void SaveUserChoice(string category)
            {
                using (var db = new Classes.AppContext())
                {
                    var option = db.Options.FirstOrDefault(o => o.Text == category);
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

