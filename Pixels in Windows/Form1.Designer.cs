﻿namespace Pixels_in_Windows
{
    partial class Form1
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
            this.PixelsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PixelsLabel
            // 
            this.PixelsLabel.AutoSize = true;
            this.PixelsLabel.Location = new System.Drawing.Point(43, 13);
            this.PixelsLabel.Name = "PixelsLabel";
            this.PixelsLabel.Size = new System.Drawing.Size(90, 13);
            this.PixelsLabel.TabIndex = 0;
            this.PixelsLabel.Text = "Pixel in windows=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PixelsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PixelsLabel;
    }
}

