using Project.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                using (var db = new Classes.AppContext())
                {
                    if (db.Users.Any(u => u.Username == TextBox_SignUpForm_Login.Text.Trim()))
                    {
                        MessageBox.Show("Это имя пользователя уже занято", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newUser = new User
                    {
                        Username = TextBox_SignUpForm_Login.Text.Trim(),
                        Password_Hash = HashPassword(TextBox_SignUpForm_Password1.Text),
                        Name = TextBox_SignUpForm_Name.Text.Trim(),
                        Created_At = DateTime.Now
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    MessageBox.Show("Вы успешно зарегистрировались!", "Все круто", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Эррор", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(TextBox_SignUpForm_Login.Text))
            {
                ShowValidationError("Введите имя пользователя", TextBox_SignUpForm_Login);
                return false;
            }

            if (string.IsNullOrWhiteSpace(TextBox_SignUpForm_Password1.Text))
            {
                ShowValidationError("Введите пароль", TextBox_SignUpForm_Password1);
                return false;
            }

            if (TextBox_SignUpForm_Password1.Text.Length < 8)
            {
                ShowValidationError("Пароль должен содержать не менее 8 символов", TextBox_SignUpForm_Password1);
                return false;
            }

            if (TextBox_SignUpForm_Password1.Text != TextBox_SignUpForm_Password2.Text)
            {
                ShowValidationError("Пароли не совпадают", TextBox_SignUpForm_Password2);
                return false;
            }

            return true;
        }

        private void ShowValidationError(string message, TextBox textBox)
        {
            MessageBox.Show(message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus();
            textBox.SelectAll();
        }

        public static string HashPassword(string inputPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
                return Convert.ToBase64String(bytes);
            }
        }
        
        /// <summary>
        /// SignUpForm_Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_SignUpForm_Login_Enter(object sender, EventArgs e)
        {
            if (TextBox_SignUpForm_Login.Text == "Username")
            {
                TextBox_SignUpForm_Login.Text = "";
                TextBox_SignUpForm_Login.ForeColor = SystemColors.WindowText;
            }
        }
        private void TextBox_SignUpForm_Login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_SignUpForm_Login.Text))
            {
                TextBox_SignUpForm_Login.Text = "Username";
                TextBox_SignUpForm_Login.ForeColor = SystemColors.GrayText;
            }
        }
        private void TextBox_SignUpForm_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == 'Ё' || e.KeyChar == 'ё')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// SignUpForm_Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_SignUpForm_Name_Enter(object sender, EventArgs e)
        {
            if (TextBox_SignUpForm_Name.Text == "Name")
            {
                TextBox_SignUpForm_Name.Text = "";
                TextBox_SignUpForm_Name.ForeColor = SystemColors.WindowText;
            }
        }
        private void TextBox_SignUpForm_Name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_SignUpForm_Name.Text))
            {
                TextBox_SignUpForm_Name.Text = "Name";
                TextBox_SignUpForm_Name.ForeColor = SystemColors.GrayText;
            }
        }
        /// <summary>
        /// SignUpForm_Password1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_SignUpForm_Password1_Enter(object sender, EventArgs e)
        {
            if (TextBox_SignUpForm_Password1.Text == "Password")
            {
                TextBox_SignUpForm_Password1.Text = "";
                TextBox_SignUpForm_Password1.ForeColor = SystemColors.WindowText;
            }
        }
        private void TextBox_SignUpForm_Password1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_SignUpForm_Password1.Text))
            {
                TextBox_SignUpForm_Password1.Text = "Password";
                TextBox_SignUpForm_Password1.ForeColor = SystemColors.GrayText;
            }
        }
        /// <summary>
        /// SignUpForm_Password2 (пароль для проверки)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_SignUpForm_Password2_Enter(object sender, EventArgs e)
        {
            if (TextBox_SignUpForm_Password2.Text == "Repeat password")
            {
                TextBox_SignUpForm_Password2.Text = "";
                TextBox_SignUpForm_Password2.ForeColor = SystemColors.WindowText;
            }
        }
        private void TextBox_SignUpForm_Password2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_SignUpForm_Password2.Text))
            {
                TextBox_SignUpForm_Password2.Text = "Repeat password";
                TextBox_SignUpForm_Password2.ForeColor = SystemColors.GrayText;
            }
        }


    }
}
