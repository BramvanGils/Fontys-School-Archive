namespace Killer_App.Forms
{
    partial class MijnProfiel
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
            this.NaamLabel = new System.Windows.Forms.Label();
            this.GebruikerPicturebox = new System.Windows.Forms.PictureBox();
            this.WinPercentageButton = new System.Windows.Forms.Button();
            this.LeavePercentageButton = new System.Windows.Forms.Button();
            this.BeschrijvingTekstbox = new System.Windows.Forms.RichTextBox();
            this.VerenigingButton = new System.Windows.Forms.Button();
            this.Chat1Button = new System.Windows.Forms.Button();
            this.Chat2Button = new System.Windows.Forms.Button();
            this.Chat3Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GebruikerPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // NaamLabel
            // 
            this.NaamLabel.AutoSize = true;
            this.NaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaamLabel.Location = new System.Drawing.Point(118, 25);
            this.NaamLabel.Name = "NaamLabel";
            this.NaamLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NaamLabel.Size = new System.Drawing.Size(335, 42);
            this.NaamLabel.TabIndex = 8;
            this.NaamLabel.Text = "<Naam Gebruiker>";
            // 
            // GebruikerPicturebox
            // 
            this.GebruikerPicturebox.Location = new System.Drawing.Point(12, 12);
            this.GebruikerPicturebox.Name = "GebruikerPicturebox";
            this.GebruikerPicturebox.Size = new System.Drawing.Size(100, 100);
            this.GebruikerPicturebox.TabIndex = 7;
            this.GebruikerPicturebox.TabStop = false;
            // 
            // WinPercentageButton
            // 
            this.WinPercentageButton.Location = new System.Drawing.Point(459, 12);
            this.WinPercentageButton.Name = "WinPercentageButton";
            this.WinPercentageButton.Size = new System.Drawing.Size(165, 100);
            this.WinPercentageButton.TabIndex = 9;
            this.WinPercentageButton.Text = "<Win Percentage>";
            this.WinPercentageButton.UseVisualStyleBackColor = true;
            // 
            // LeavePercentageButton
            // 
            this.LeavePercentageButton.Location = new System.Drawing.Point(630, 12);
            this.LeavePercentageButton.Name = "LeavePercentageButton";
            this.LeavePercentageButton.Size = new System.Drawing.Size(165, 100);
            this.LeavePercentageButton.TabIndex = 10;
            this.LeavePercentageButton.Text = "<Leave Percentage>";
            this.LeavePercentageButton.UseVisualStyleBackColor = true;
            // 
            // BeschrijvingTekstbox
            // 
            this.BeschrijvingTekstbox.Location = new System.Drawing.Point(459, 119);
            this.BeschrijvingTekstbox.Name = "BeschrijvingTekstbox";
            this.BeschrijvingTekstbox.Size = new System.Drawing.Size(336, 252);
            this.BeschrijvingTekstbox.TabIndex = 11;
            this.BeschrijvingTekstbox.Text = "";
            // 
            // VerenigingButton
            // 
            this.VerenigingButton.Location = new System.Drawing.Point(12, 378);
            this.VerenigingButton.Name = "VerenigingButton";
            this.VerenigingButton.Size = new System.Drawing.Size(776, 60);
            this.VerenigingButton.TabIndex = 12;
            this.VerenigingButton.Text = "button1";
            this.VerenigingButton.UseVisualStyleBackColor = true;
            // 
            // Chat1Button
            // 
            this.Chat1Button.Location = new System.Drawing.Point(13, 119);
            this.Chat1Button.Name = "Chat1Button";
            this.Chat1Button.Size = new System.Drawing.Size(440, 79);
            this.Chat1Button.TabIndex = 13;
            this.Chat1Button.Text = "button1";
            this.Chat1Button.UseVisualStyleBackColor = true;
            // 
            // Chat2Button
            // 
            this.Chat2Button.Location = new System.Drawing.Point(13, 204);
            this.Chat2Button.Name = "Chat2Button";
            this.Chat2Button.Size = new System.Drawing.Size(440, 79);
            this.Chat2Button.TabIndex = 14;
            this.Chat2Button.Text = "button2";
            this.Chat2Button.UseVisualStyleBackColor = true;
            // 
            // Chat3Button
            // 
            this.Chat3Button.Location = new System.Drawing.Point(13, 289);
            this.Chat3Button.Name = "Chat3Button";
            this.Chat3Button.Size = new System.Drawing.Size(440, 79);
            this.Chat3Button.TabIndex = 15;
            this.Chat3Button.Text = "button3";
            this.Chat3Button.UseVisualStyleBackColor = true;
            // 
            // MijnProfiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Chat3Button);
            this.Controls.Add(this.Chat2Button);
            this.Controls.Add(this.Chat1Button);
            this.Controls.Add(this.VerenigingButton);
            this.Controls.Add(this.BeschrijvingTekstbox);
            this.Controls.Add(this.LeavePercentageButton);
            this.Controls.Add(this.WinPercentageButton);
            this.Controls.Add(this.NaamLabel);
            this.Controls.Add(this.GebruikerPicturebox);
            this.Name = "MijnProfiel";
            this.Text = "MijnProfiel";
            ((System.ComponentModel.ISupportInitialize)(this.GebruikerPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaamLabel;
        private System.Windows.Forms.PictureBox GebruikerPicturebox;
        private System.Windows.Forms.Button WinPercentageButton;
        private System.Windows.Forms.Button LeavePercentageButton;
        private System.Windows.Forms.RichTextBox BeschrijvingTekstbox;
        private System.Windows.Forms.Button VerenigingButton;
        private System.Windows.Forms.Button Chat1Button;
        private System.Windows.Forms.Button Chat2Button;
        private System.Windows.Forms.Button Chat3Button;
    }
}