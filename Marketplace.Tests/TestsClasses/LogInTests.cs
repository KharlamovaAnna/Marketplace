using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Classes;
using Project.Forms;
using Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Tests
{
    [TestClass]
    public class LogInTests
    {
        /// <summary>
        /// тест: метод VerifyPassword возвращает true,  если пароль правильный
        /// </summary>
        [TestMethod]
        public void VerifyPassword_CorrectPassword_ReturnsTrue()
        {
            // Arrange
            string password = "TestPassword";
            string hashedPassword = SignUp.HashPassword(password);

            // Act
            bool result = LogIn.VerifyPassword(password, hashedPassword);

            // Assert
            Assert.IsTrue(result, "Правильный пароль должен пройти проверку");
        }

        /// <summary>
        /// тест: метод VerifyPassword возвращает false, если пароль неправильный
        /// </summary>
        [TestMethod]
        public void VerifyPassword_WrongPassword_ReturnsFalse()
        {
            // Arrange
            string hashedPassword = SignUp.HashPassword("CorrectPassword");

            // Act
            bool result = LogIn.VerifyPassword("WrongPassword", hashedPassword);

            // Assert
            Assert.IsFalse(result, "Неправильный пароль должен быть отклонен");
        }

        
    }
}
