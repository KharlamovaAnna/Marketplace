using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Forms;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Marketplace.Tests
{
    [TestClass]
    public class SignUpTests
    {
        /// <summary>
        /// тест: одинаковые пароль дают одинаковые хэши
        /// </summary>
        [TestMethod]
        public void HashPassword_SamePasswords_ReturnSameHash()
        {
            string hash1 = SignUp.HashPassword("password");
            string hash2 = SignUp.HashPassword("password");

            Assert.AreEqual(hash1, hash2);
        }

        /// <summary>
        /// тест: пустой логин возвраащет false
        /// </summary>
        [TestMethod]
        public void ValidateInput_EmptyLogin_ReturnsFalse()
        {
            var signUpForm = new SignUp();
            var textBox = new TextBox { Text = "" };

            typeof(SignUp).GetField("TextBox_SignUpForm_Login", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(signUpForm, textBox);

            var result = (bool)typeof(SignUp).GetMethod("ValidateInput", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(signUpForm, null);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// тест: совпадающие логины возвращают true
        /// </summary>
        [TestMethod]
        public void ValidateInput_MatchingPasswords_ReturnsTrue()
        {
            var signUpForm = new SignUp();
            var textBox1 = new TextBox { Text = "password123" };
            var textBox2 = new TextBox { Text = "password123" };

            typeof(SignUp).GetField("TextBox_SignUpForm_Password1", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(signUpForm, textBox1);
            typeof(SignUp).GetField("TextBox_SignUpForm_Password2", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(signUpForm, textBox2);

            var result = (bool)typeof(SignUp).GetMethod("ValidateInput", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(signUpForm, null);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TextBox_SignUpForm_Login_KeyPress_RussianLettersBlocked()
        {
            var signUpForm = new SignUp();
            var textBox = new TextBox();
            var e = new KeyPressEventArgs('а');

            typeof(SignUp).GetMethod("TextBox_SignUpForm_Login_KeyPress", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(signUpForm, new object[] { textBox, e });

            Assert.IsTrue(e.Handled);
        }

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
