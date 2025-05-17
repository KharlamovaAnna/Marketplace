namespace Project.Forms
{
    partial class ChooseItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseItem));
            this.checkedListBoxItems = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxItems
            // 
            this.checkedListBoxItems.FormattingEnabled = true;
            this.checkedListBoxItems.Location = new System.Drawing.Point(90, 155);
            this.checkedListBoxItems.Name = "checkedListBoxItems";
            this.checkedListBoxItems.Size = new System.Drawing.Size(260, 169);
            this.checkedListBoxItems.TabIndex = 0;
            // 
            // ChooseItem
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(444, 442);
            this.Controls.Add(this.checkedListBoxItems);
            this.MaximizeBox = false;
            this.Name = "ChooseItem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxItems;
    }
}