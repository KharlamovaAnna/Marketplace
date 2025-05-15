namespace Project.Forms
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.TextBox_SignUpForm_Login = new System.Windows.Forms.TextBox();
            this.TextBox_SignUpForm_Password1 = new System.Windows.Forms.TextBox();
            this.TextBox_SignUpForm_Password2 = new System.Windows.Forms.TextBox();
            this.TextBox_SignUpForm_Name = new System.Windows.Forms.TextBox();
            this.Button_SignUpForm_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_SignUpForm_Login
            // 
            this.TextBox_SignUpForm_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.TextBox_SignUpForm_Login.Location = new System.Drawing.Point(110, 154);
            this.TextBox_SignUpForm_Login.MaxLength = 20;
            this.TextBox_SignUpForm_Login.Multiline = true;
            this.TextBox_SignUpForm_Login.Name = "TextBox_SignUpForm_Login";
            this.TextBox_SignUpForm_Login.Size = new System.Drawing.Size(255, 43);
            this.TextBox_SignUpForm_Login.TabIndex = 4;
            this.TextBox_SignUpForm_Login.Enter += new System.EventHandler(this.TextBox_SignUpForm_Login_Enter);
            this.TextBox_SignUpForm_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_SignUpForm_Login_KeyPress);
            this.TextBox_SignUpForm_Login.Leave += new System.EventHandler(this.TextBox_SignUpForm_Login_Leave);
            // 
            // TextBox_SignUpForm_Password1
            // 
            this.TextBox_SignUpForm_Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.TextBox_SignUpForm_Password1.Location = new System.Drawing.Point(110, 252);
            this.TextBox_SignUpForm_Password1.MaxLength = 100;
            this.TextBox_SignUpForm_Password1.Multiline = true;
            this.TextBox_SignUpForm_Password1.Name = "TextBox_SignUpForm_Password1";
            this.TextBox_SignUpForm_Password1.Size = new System.Drawing.Size(255, 43);
            this.TextBox_SignUpForm_Password1.TabIndex = 5;
            this.TextBox_SignUpForm_Password1.Enter += new System.EventHandler(this.TextBox_SignUpForm_Password1_Enter);
            this.TextBox_SignUpForm_Password1.Leave += new System.EventHandler(this.TextBox_SignUpForm_Password1_Leave);
            // 
            // TextBox_SignUpForm_Password2
            // 
            this.TextBox_SignUpForm_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.TextBox_SignUpForm_Password2.Location = new System.Drawing.Point(110, 301);
            this.TextBox_SignUpForm_Password2.MaxLength = 100;
            this.TextBox_SignUpForm_Password2.Multiline = true;
            this.TextBox_SignUpForm_Password2.Name = "TextBox_SignUpForm_Password2";
            this.TextBox_SignUpForm_Password2.Size = new System.Drawing.Size(255, 43);
            this.TextBox_SignUpForm_Password2.TabIndex = 6;
            this.TextBox_SignUpForm_Password2.Enter += new System.EventHandler(this.TextBox_SignUpForm_Password2_Enter);
            this.TextBox_SignUpForm_Password2.Leave += new System.EventHandler(this.TextBox_SignUpForm_Password2_Leave);
            // 
            // TextBox_SignUpForm_Name
            // 
            this.TextBox_SignUpForm_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.TextBox_SignUpForm_Name.Location = new System.Drawing.Point(110, 203);
            this.TextBox_SignUpForm_Name.MaxLength = 20;
            this.TextBox_SignUpForm_Name.Multiline = true;
            this.TextBox_SignUpForm_Name.Name = "TextBox_SignUpForm_Name";
            this.TextBox_SignUpForm_Name.Size = new System.Drawing.Size(255, 43);
            this.TextBox_SignUpForm_Name.TabIndex = 7;
            this.TextBox_SignUpForm_Name.Enter += new System.EventHandler(this.TextBox_SignUpForm_Name_Enter);
            this.TextBox_SignUpForm_Name.Leave += new System.EventHandler(this.TextBox_SignUpForm_Name_Leave);
            // 
            // Button_SignUpForm_SignUp
            // 
            this.Button_SignUpForm_SignUp.Location = new System.Drawing.Point(130, 350);
            this.Button_SignUpForm_SignUp.Name = "Button_SignUpForm_SignUp";
            this.Button_SignUpForm_SignUp.Size = new System.Drawing.Size(213, 44);
            this.Button_SignUpForm_SignUp.TabIndex = 8;
            this.Button_SignUpForm_SignUp.Text = "Зарегистрироваться";
            this.Button_SignUpForm_SignUp.UseVisualStyleBackColor = true;
            this.Button_SignUpForm_SignUp.Click += new System.EventHandler(this.Button_SignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(476, 475);
            this.Controls.Add(this.Button_SignUpForm_SignUp);
            this.Controls.Add(this.TextBox_SignUpForm_Name);
            this.Controls.Add(this.TextBox_SignUpForm_Password2);
            this.Controls.Add(this.TextBox_SignUpForm_Password1);
            this.Controls.Add(this.TextBox_SignUpForm_Login);
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_SignUpForm_Login;
        public System.Windows.Forms.TextBox TextBox_SignUpForm_Password1;
        public System.Windows.Forms.TextBox TextBox_SignUpForm_Password2;
        private System.Windows.Forms.TextBox TextBox_SignUpForm_Name;
        private System.Windows.Forms.Button Button_SignUpForm_SignUp;
    }
}