namespace Killer_App.Forms
{
    partial class Chat
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
            this.GebruikerPicturebox = new System.Windows.Forms.PictureBox();
            this.NaamLabel = new System.Windows.Forms.Label();
            this.ClubButton = new System.Windows.Forms.Button();
            this.RematchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GebruikerPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // GebruikerPicturebox
            // 
            this.GebruikerPicturebox.Location = new System.Drawing.Point(13, 13);
            this.GebruikerPicturebox.Name = "GebruikerPicturebox";
            this.GebruikerPicturebox.Size = new System.Drawing.Size(100, 100);
            this.GebruikerPicturebox.TabIndex = 0;
            this.GebruikerPicturebox.TabStop = false;
            // 
            // NaamLabel
            // 
            this.NaamLabel.AutoSize = true;
            this.NaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaamLabel.Location = new System.Drawing.Point(119, 26);
            this.NaamLabel.Name = "NaamLabel";
            this.NaamLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NaamLabel.Size = new System.Drawing.Size(335, 42);
            this.NaamLabel.TabIndex = 6;
            this.NaamLabel.Text = "<Naam Gebruiker>";
            // 
            // ClubButton
            // 
            this.ClubButton.Location = new System.Drawing.Point(688, 12);
            this.ClubButton.Name = "ClubButton";
            this.ClubButton.Size = new System.Drawing.Size(100, 100);
            this.ClubButton.TabIndex = 7;
            this.ClubButton.Text = "Club";
            this.ClubButton.UseVisualStyleBackColor = true;
            // 
            // RematchButton
            // 
            this.RematchButton.Location = new System.Drawing.Point(582, 12);
            this.RematchButton.Name = "RematchButton";
            this.RematchButton.Size = new System.Drawing.Size(100, 100);
            this.RematchButton.TabIndex = 8;
            this.RematchButton.Text = "Rematch";
            this.RematchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RematchButton);
            this.Controls.Add(this.ClubButton);
            this.Controls.Add(this.NaamLabel);
            this.Controls.Add(this.GebruikerPicturebox);
            this.Name = "Chat";
            this.Text = "Chat";
            ((System.ComponentModel.ISupportInitialize)(this.GebruikerPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GebruikerPicturebox;
        private System.Windows.Forms.Label NaamLabel;
        private System.Windows.Forms.Button ClubButton;
        private System.Windows.Forms.Button RematchButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}