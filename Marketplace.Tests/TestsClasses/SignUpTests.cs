using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Forms;
using System;

namespace Marketplace.Tests
{
    [TestClass]
    public class SignUpTests
    {
        /// <summary>
        /// Тест: проверяет, что метод хеширования пароля всегда возвращает одинаковый результат при одинаковом входном пароле
        /// </summary>
        [TestMethod]
        public void HashPassword_ReturnsConsistentHash()
        {
            string password = "TestPassword123";

            string hash1 = SignUp.HashPassword(password);
            string hash2 = SignUp.HashPassword(password);

            Assert.AreEqual(hash1, hash2, "Хеши одного пароля должны совпадать");
        }

        /// <summary>
        /// тест: проверяет, что валидация формы отклоняет слишком короткий пароль (меньше 8 символов)
        /// </summary>
        [TestMethod]
        public void ValidateInput_RejectsShortPassword()
        {
            var form = new SignUp();
            form.TextBox_SignUpForm_Password1.Text = "123"; // Пароль короче 8 символов

            bool isValid = form.ValidateInput();

            Assert.IsFalse(isValid, "Короткий пароль должен быть отклонен");
        }

        /// <summary>
        /// тест: тест гарантирует, что пользователь не сможет зарегистрироваться с паролем меньше 8 символов 
        /// </summary>
        [TestMethod]
        public void ValidateInput_RejectsMismatchedPasswords()
        {
            var form = new SignUp();
            form.TextBox_SignUpForm_Password1.Text = "Password123";
            form.TextBox_SignUpForm_Password2.Text = "Password456";

            bool isValid = form.ValidateInput();

            Assert.IsFalse(isValid, "Несовпадающие пароли должны быть отклонены");
        }
    }
}
