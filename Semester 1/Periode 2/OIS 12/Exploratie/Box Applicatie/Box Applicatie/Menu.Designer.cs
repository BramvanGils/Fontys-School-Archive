﻿namespace Box_Applicatie
{
    partial class Menu
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
            this.WedstrijdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WedstrijdButton
            // 
            this.WedstrijdButton.Location = new System.Drawing.Point(13, 13);
            this.WedstrijdButton.Name = "WedstrijdButton";
            this.WedstrijdButton.Size = new System.Drawing.Size(75, 23);
            this.WedstrijdButton.TabIndex = 0;
            this.WedstrijdButton.Text = "Wedstrijd";
            this.WedstrijdButton.UseVisualStyleBackColor = true;
            this.WedstrijdButton.Click += new System.EventHandler(this.WedstrijdButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WedstrijdButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WedstrijdButton;
    }
}