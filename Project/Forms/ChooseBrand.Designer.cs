﻿namespace Project.Forms
{
    partial class ChooseBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseBrand));
            this.checkedListBoxBrands = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxBrands
            // 
            this.checkedListBoxBrands.FormattingEnabled = true;
            this.checkedListBoxBrands.Location = new System.Drawing.Point(117, 182);
            this.checkedListBoxBrands.Name = "checkedListBoxBrands";
            this.checkedListBoxBrands.Size = new System.Drawing.Size(297, 214);
            this.checkedListBoxBrands.TabIndex = 0;
            // 
            // ChooseBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(531, 528);
            this.Controls.Add(this.checkedListBoxBrands);
            this.MaximizeBox = false;
            this.Name = "ChooseBrand";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxBrands;
    }
}