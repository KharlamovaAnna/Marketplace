using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Classes;
using Project.Forms;
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
    public class LogInTests
    {

        /// <summary>
        /// тест: правильный пароль возвращает true
        /// </summary>
        [TestMethod]
        public void VerifyPassword_CorrectPassword_ReturnsTrue()
        {
            string password = "TestPassword";
            string hashedPassword = SignUp.HashPassword(password);

            bool result = LogIn.VerifyPassword(password, hashedPassword);

            Assert.IsTrue(result, "Правильный пароль должен пройти проверку");
        }

        /// <summary>
        /// тест: неправильный пароль возвращает false
        /// </summary>
        [TestMethod]
        public void VerifyPassword_IncorrectPassword_ReturnsFalse()
        {
            string correctHash = SignUp.HashPassword("CorrectPassword");

            bool result = LogIn.VerifyPassword("WrongPassword", correctHash);

            Assert.IsFalse(result, "Неправильный пароль должен быть отклонен");
        }

        /// <summary>
        /// тест: регистрация прошла успешно
        /// </summary>
        [TestMethod]
        public void Button_LogInForm_LogIn_Click_UserNotFound_ReturnsNull()
        {
            var loginForm = new LogIn();
            loginForm.TextBox_LogInForm_LogIn.Text = "NonExistentUser";
            loginForm.TextBox_LogInForm_Password.Text = "AnyPassword";

            loginForm.Button_LogInForm_LogIn_Click(null, EventArgs.Empty);

            Assert.IsNull(loginForm.AuthenticatedUser);
        }

        /// <summary>
        /// тест: проверяет, что форма логина не регистрирует пользователя при пустом пароле
        /// </summary>
        [TestMethod]
        public void Button_LogIn_Click_EmptyPassword_DoesNotAuthenticateUser()
        {
            var loginForm = new LogIn();
            loginForm.TextBox_LogInForm_LogIn.Text = "testuser";
            loginForm.TextBox_LogInForm_Password.Text = "";

            loginForm.Button_LogInForm_LogIn_Click(null, EventArgs.Empty);

            Assert.IsNull(loginForm.AuthenticatedUser);
        }

    }
}
