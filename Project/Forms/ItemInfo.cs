using System.Windows.Forms;

namespace Project.Forms
{
    public partial class ItemInfo : Form
    {
        public ItemInfo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Button_ItemInfoForm_Favourites_Click(object sender, System.EventArgs e)
        {
            Favourite favourite = new Favourite();
            favourite.Show();
        }

      
    }
}
