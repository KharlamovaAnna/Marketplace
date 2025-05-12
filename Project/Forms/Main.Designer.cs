using System.Drawing;

namespace Project
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Button_MainForm_LogInOpenForm = new System.Windows.Forms.Button();
            this.Button_MainForm_SignUpOpenForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_MainForm_LogInOpenForm
            // 
            this.Button_MainForm_LogInOpenForm.BackColor = System.Drawing.Color.Transparent;
            this.Button_MainForm_LogInOpenForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_MainForm_LogInOpenForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MainForm_LogInOpenForm.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_MainForm_LogInOpenForm.ForeColor = System.Drawing.Color.White;
            this.Button_MainForm_LogInOpenForm.Location = new System.Drawing.Point(280, 200);
            this.Button_MainForm_LogInOpenForm.Name = "Button_MainForm_LogInOpenForm";
            this.Button_MainForm_LogInOpenForm.Size = new System.Drawing.Size(199, 61);
            this.Button_MainForm_LogInOpenForm.TabIndex = 0;
            this.Button_MainForm_LogInOpenForm.UseVisualStyleBackColor = false;
            this.Button_MainForm_LogInOpenForm.Click += new System.EventHandler(this.Button_MainForm_LogInOpenForm_Click);
            // 
            // Button_MainForm_SignUpOpenForm
            // 
            this.Button_MainForm_SignUpOpenForm.BackColor = System.Drawing.Color.Transparent;
            this.Button_MainForm_SignUpOpenForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_MainForm_SignUpOpenForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MainForm_SignUpOpenForm.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_MainForm_SignUpOpenForm.ForeColor = System.Drawing.Color.White;
            this.Button_MainForm_SignUpOpenForm.Location = new System.Drawing.Point(280, 293);
            this.Button_MainForm_SignUpOpenForm.Name = "Button_MainForm_SignUpOpenForm";
            this.Button_MainForm_SignUpOpenForm.Size = new System.Drawing.Size(199, 56);
            this.Button_MainForm_SignUpOpenForm.TabIndex = 2;
            this.Button_MainForm_SignUpOpenForm.UseVisualStyleBackColor = false;
            this.Button_MainForm_SignUpOpenForm.Click += new System.EventHandler(this.Button_MainForm_SignUpOpenForm_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(491, 489);
            this.Controls.Add(this.Button_MainForm_SignUpOpenForm);
            this.Controls.Add(this.Button_MainForm_LogInOpenForm);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_MainForm_LogInOpenForm;
        private System.Windows.Forms.Button Button_MainForm_SignUpOpenForm;
    }
}

