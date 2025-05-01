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
            button1.BackColor = Color.FromArgb(252, 110, 48);
            //button1.BackColor = Color.Transparent;
            button2.BackColor = Color.FromArgb(0, 49, 216);
        }
        private void LogIn_OpenForm_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            logInForm.Show();
            logInForm.FormClosed += (s, args) => this.Show();

            this.Hide();
        }

    }
}
