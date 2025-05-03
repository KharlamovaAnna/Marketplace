using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            //button1.BackColor = Color.Transparent;
        }
       
        private void LogIn_Load(object sender, EventArgs e)
        {
            this.Focus();      
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Name") 
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Name";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = SystemColors.GrayText;
            }
        }


    }
}
