using System.Drawing;
using System.Windows.Forms;

namespace Project.Forms
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.TextBox_LogInForm_LogIn = new System.Windows.Forms.TextBox();
            this.TextBox_LogInForm_Password = new System.Windows.Forms.TextBox();
            this.Button_LogInForm_LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_LogInForm_LogIn
            // 
            this.TextBox_LogInForm_LogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_LogInForm_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_LogInForm_LogIn.Location = new System.Drawing.Point(116, 180);
            this.TextBox_LogInForm_LogIn.MaxLength = 15;
            this.TextBox_LogInForm_LogIn.Multiline = true;
            this.TextBox_LogInForm_LogIn.Name = "TextBox_LogInForm_LogIn";
            this.TextBox_LogInForm_LogIn.Size = new System.Drawing.Size(242, 40);
            this.TextBox_LogInForm_LogIn.TabIndex = 0;
            this.TextBox_LogInForm_LogIn.Enter += new System.EventHandler(this.TextBox_LogInForm_LogIn_Enter);
            this.TextBox_LogInForm_LogIn.Leave += new System.EventHandler(this.TextBox_LogInForm_LogIn_Leave);
            // 
            // TextBox_LogInForm_Password
            // 
            this.TextBox_LogInForm_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_LogInForm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.TextBox_LogInForm_Password.Location = new System.Drawing.Point(116, 257);
            this.TextBox_LogInForm_Password.Multiline = true;
            this.TextBox_LogInForm_Password.Name = "TextBox_LogInForm_Password";
            this.TextBox_LogInForm_Password.Size = new System.Drawing.Size(242, 40);
            this.TextBox_LogInForm_Password.TabIndex = 1;
            this.TextBox_LogInForm_Password.Enter += new System.EventHandler(this.TextBox_LogInForm_Password_Enter);
            this.TextBox_LogInForm_Password.Leave += new System.EventHandler(this.TextBox_LogInForm_Password_Leave);
            // 
            // Button_LogInForm_LogIn
            // 
            this.Button_LogInForm_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.Button_LogInForm_LogIn.FlatAppearance.BorderSize = 0;
            this.Button_LogInForm_LogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_LogInForm_LogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_LogInForm_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_LogInForm_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_LogInForm_LogIn.ForeColor = System.Drawing.Color.Snow;
            this.Button_LogInForm_LogIn.Location = new System.Drawing.Point(103, 328);
            this.Button_LogInForm_LogIn.Name = "Button_LogInForm_LogIn";
            this.Button_LogInForm_LogIn.Size = new System.Drawing.Size(279, 43);
            this.Button_LogInForm_LogIn.TabIndex = 2;
            this.Button_LogInForm_LogIn.Text = "Log In";
            this.Button_LogInForm_LogIn.UseVisualStyleBackColor = false;
            this.Button_LogInForm_LogIn.Click += new System.EventHandler(this.Button_LogInForm_LogIn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(478, 478);
            this.Controls.Add(this.Button_LogInForm_LogIn);
            this.Controls.Add(this.TextBox_LogInForm_Password);
            this.Controls.Add(this.TextBox_LogInForm_LogIn);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TextBox_LogInForm_LogIn;
        public System.Windows.Forms.TextBox TextBox_LogInForm_Password;
        public System.Windows.Forms.Button Button_LogInForm_LogIn;
    }
}