using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketplace.Tests
{
    [TestClass]
    public class ItemInfoTests
    {
        /// <summary>
        /// тест: проверяет, что при нажатии на кнопку открывается форма "Избранное"
        /// </summary>
        [TestMethod]
        public void Button_ItemInfoForm_Favourites_Click_OpensFavouriteForm()
        {
            Form favouriteForm = null;

            var thread = new System.Threading.Thread(() =>
            {
                var itemInfoForm = new ItemInfo();
                itemInfoForm.Button_ItemInfoForm_Favourites_Click(null, EventArgs.Empty);
                favouriteForm = Application.OpenForms.OfType<Favourite>().FirstOrDefault();
            });

            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            thread.Join();

            Assert.IsNotNull(favouriteForm, "Форма Favourite должна открыться");
        }
    }
}
