using Project.Classes;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class ItemInfo : Form
    {
        private readonly Product currentProduct;
        private readonly int userID;

        public ItemInfo(int userID, Product product)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userID = userID;
            this.currentProduct = product;
            //labelProductName.Text = product.Name;
            //labelDescription.Text = product.Description;
        }

        private void Button_ItemInfoForm_Favourites_Click(object sender, System.EventArgs e)
        {
            
        }

      
    }
}
