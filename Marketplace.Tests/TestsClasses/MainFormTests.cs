using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Forms;
using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketplace.Tests
{
    [TestClass]
    public class MainFormTests
    {
        /// <summary>
        /// тест: проверяет, что открывается форма авторизации
        /// </summary>
        [TestMethod]
        public void Button_LogInOpenForm_OpensLogInForm()
        {
            var mainForm = new Main();

            mainForm.Button_MainForm_LogInOpenForm_Click(null, EventArgs.Empty);

            var loginForm = Application.OpenForms.OfType<LogIn>().FirstOrDefault();
            Assert.IsNotNull(loginForm, "Форма LogIn должна открыться");
            Assert.IsFalse(mainForm.Visible, "Главная форма должна быть скрыта");
        }


        /// <summary>
        /// тест: проверяет, что открывается форма регистрации
        /// </summary>
        [TestMethod]
        public void Button_SignUpOpenForm_OpensSignUpForm()
        {
            var mainForm = new Main();

            mainForm.Button_MainForm_SignUpOpenForm_Click(null, EventArgs.Empty);

            var signUpForm = Application.OpenForms.OfType<SignUp>().FirstOrDefault();
            Assert.IsNotNull(signUpForm, "Форма SignUp должна открыться");
            Assert.IsFalse(mainForm.Visible, "Главная форма должна быть скрыта");
        }
    }
}
