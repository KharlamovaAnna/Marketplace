using Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Button_MainForm_LogInOpenForm_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            logInForm.Show();
            logInForm.FormClosed += (s, args) => this.Show();

            this.Hide();
        }
        private void Button_MainForm_SignUpOpenForm_Click(object sender, EventArgs e)
        {
            SignUp SignUpForm = new SignUp();
            SignUpForm.Show();
            SignUpForm.FormClosed += (s, args) => this.Show();

            this.Hide();
        }
    }
}
