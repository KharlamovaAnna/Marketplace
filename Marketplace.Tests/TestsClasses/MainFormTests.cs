using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Forms;
using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Marketplace.Tests
{
    [TestClass]
    public class MainTests
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
        /// тест: проверяет, что форма LogIn открывается в правильном потоке
        /// </summary>
        [TestMethod]
        public void Button_LogInOpenForm_OpensLogInForm()
        {
            Form loginForm = null;

            var thread = new System.Threading.Thread(() =>
            {
                var mainForm = new Main();
                mainForm.Button_MainForm_LogInOpenForm_Click(null, EventArgs.Empty);
                loginForm = System.Windows.Forms.Application.OpenForms.OfType<LogIn>().FirstOrDefault();
            });

            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            thread.Join(); 

            Assert.IsNotNull(loginForm, "Форма LogIn должна открыться");
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
