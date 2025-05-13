namespace Project.Forms
{
    partial class ItemInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInfo));
            this.Button_ItemInfoForm_Like = new System.Windows.Forms.Button();
            this.Button_ItemInfoForm_Dislike = new System.Windows.Forms.Button();
            this.Button_ItemInfoForm_Favourites = new System.Windows.Forms.Button();
            this.Textbox_ItemInfoForm_ItemName = new System.Windows.Forms.TextBox();
            this.Textbox_ItemInfoForm_ItemDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_ItemInfoForm_Like
            // 
            this.Button_ItemInfoForm_Like.BackColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Like.FlatAppearance.BorderSize = 0;
            this.Button_ItemInfoForm_Like.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Like.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ItemInfoForm_Like.ForeColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Like.Location = new System.Drawing.Point(234, 347);
            this.Button_ItemInfoForm_Like.Name = "Button_ItemInfoForm_Like";
            this.Button_ItemInfoForm_Like.Size = new System.Drawing.Size(70, 50);
            this.Button_ItemInfoForm_Like.TabIndex = 0;
            this.Button_ItemInfoForm_Like.UseVisualStyleBackColor = false;
            // 
            // Button_ItemInfoForm_Dislike
            // 
            this.Button_ItemInfoForm_Dislike.BackColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Dislike.FlatAppearance.BorderSize = 0;
            this.Button_ItemInfoForm_Dislike.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Dislike.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Dislike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ItemInfoForm_Dislike.Location = new System.Drawing.Point(319, 347);
            this.Button_ItemInfoForm_Dislike.Name = "Button_ItemInfoForm_Dislike";
            this.Button_ItemInfoForm_Dislike.Size = new System.Drawing.Size(63, 50);
            this.Button_ItemInfoForm_Dislike.TabIndex = 1;
            this.Button_ItemInfoForm_Dislike.UseVisualStyleBackColor = false;
            // 
            // Button_ItemInfoForm_Favourites
            // 
            this.Button_ItemInfoForm_Favourites.BackColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Favourites.FlatAppearance.BorderSize = 0;
            this.Button_ItemInfoForm_Favourites.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Favourites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_ItemInfoForm_Favourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ItemInfoForm_Favourites.Location = new System.Drawing.Point(48, 426);
            this.Button_ItemInfoForm_Favourites.Name = "Button_ItemInfoForm_Favourites";
            this.Button_ItemInfoForm_Favourites.Size = new System.Drawing.Size(360, 53);
            this.Button_ItemInfoForm_Favourites.TabIndex = 2;
            this.Button_ItemInfoForm_Favourites.UseVisualStyleBackColor = false;
            // 
            // Textbox_ItemInfoForm_ItemName
            // 
            this.Textbox_ItemInfoForm_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_ItemInfoForm_ItemName.Location = new System.Drawing.Point(66, 41);
            this.Textbox_ItemInfoForm_ItemName.Multiline = true;
            this.Textbox_ItemInfoForm_ItemName.Name = "Textbox_ItemInfoForm_ItemName";
            this.Textbox_ItemInfoForm_ItemName.Size = new System.Drawing.Size(325, 49);
            this.Textbox_ItemInfoForm_ItemName.TabIndex = 3;
            // 
            // Textbox_ItemInfoForm_ItemDescription
            // 
            this.Textbox_ItemInfoForm_ItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_ItemInfoForm_ItemDescription.Location = new System.Drawing.Point(66, 291);
            this.Textbox_ItemInfoForm_ItemDescription.Multiline = true;
            this.Textbox_ItemInfoForm_ItemDescription.Name = "Textbox_ItemInfoForm_ItemDescription";
            this.Textbox_ItemInfoForm_ItemDescription.Size = new System.Drawing.Size(325, 38);
            this.Textbox_ItemInfoForm_ItemDescription.TabIndex = 4;
            // 
            // ItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(463, 502);
            this.Controls.Add(this.Textbox_ItemInfoForm_ItemDescription);
            this.Controls.Add(this.Textbox_ItemInfoForm_ItemName);
            this.Controls.Add(this.Button_ItemInfoForm_Favourites);
            this.Controls.Add(this.Button_ItemInfoForm_Dislike);
            this.Controls.Add(this.Button_ItemInfoForm_Like);
            this.Name = "ItemInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ItemInfoForm_Like;
        private System.Windows.Forms.Button Button_ItemInfoForm_Dislike;
        private System.Windows.Forms.Button Button_ItemInfoForm_Favourites;
        private System.Windows.Forms.TextBox Textbox_ItemInfoForm_ItemName;
        private System.Windows.Forms.TextBox Textbox_ItemInfoForm_ItemDescription;
    }
}