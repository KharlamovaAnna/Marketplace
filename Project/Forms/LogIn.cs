using Project.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// TextBox_LogInForm_LogIn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_LogInForm_LogIn_Enter(object sender, EventArgs e)
        {
            if (TextBox_LogInForm_LogIn.Text == "Username")
            {
                TextBox_LogInForm_LogIn.Text = "";
                TextBox_LogInForm_LogIn.ForeColor = SystemColors.WindowText;
            }
        }
        private void TextBox_LogInForm_LogIn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_LogInForm_LogIn.Text))
            {
                TextBox_LogInForm_LogIn.Text = "Username";
                TextBox_LogInForm_LogIn.ForeColor = SystemColors.GrayText;
            }
        }
        /// <summary>
        /// TextBox_LogInForm_Password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_LogInForm_Password_Enter(object sender, EventArgs e)
        {
            if (TextBox_LogInForm_Password.Text == "Password")
            {
                TextBox_LogInForm_Password.Text = "";
                TextBox_LogInForm_Password.ForeColor = SystemColors.WindowText;
            }
        }
        private void TextBox_LogInForm_Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox_LogInForm_Password.Text))
            {
                TextBox_LogInForm_Password.Text = "Password";
                TextBox_LogInForm_Password.ForeColor = SystemColors.GrayText;
            }
        }

        public User AuthenticatedUser { get; private set; }
        /// <summary>
        /// ну вход короче туда сюда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_LogInForm_LogIn_Click(object sender, EventArgs e)
        {
            using (var db = new Classes.AppContext())
            {
                var user = db.Users.AsNoTracking().FirstOrDefault(u => u.Username.Equals(TextBox_LogInForm_LogIn.Text.Trim(), StringComparison.Ordinal));

                if (user == null)
                {
                    MessageBox.Show("Пользователь с таким именем не найден", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!VerifyPassword(TextBox_LogInForm_Password.Text, user.Password_Hash))
                {
                    MessageBox.Show("Неверный пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AuthenticatedUser = user;
                MessageBox.Show($"Добро пожаловать, {user.Name}!", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            string inputHash = SignUp.HashPassword(password);
            return inputHash == hashedPassword;
        }
    }

        
    }

