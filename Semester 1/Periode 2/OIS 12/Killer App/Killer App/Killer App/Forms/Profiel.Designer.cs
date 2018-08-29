namespace Killer_App.Forms
{
    partial class Profiel
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
            this.WinPercentageButton = new System.Windows.Forms.Button();
            this.LeavePercentageButton = new System.Windows.Forms.Button();
            this.BeschrijvingTekstbox = new System.Windows.Forms.RichTextBox();
            this.VerenigingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GebruikerPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // GebruikerPicturebox
            // 
            this.GebruikerPicturebox.Location = new System.Drawing.Point(102, 119);
            this.GebruikerPicturebox.Name = "GebruikerPicturebox";
            this.GebruikerPicturebox.Size = new System.Drawing.Size(253, 253);
            this.GebruikerPicturebox.TabIndex = 16;
            this.GebruikerPicturebox.TabStop = false;
            // 
            // NaamLabel
            // 
            this.NaamLabel.AutoSize = true;
            this.NaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaamLabel.Location = new System.Drawing.Point(59, 32);
            this.NaamLabel.Name = "NaamLabel";
            this.NaamLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NaamLabel.Size = new System.Drawing.Size(335, 42);
            this.NaamLabel.TabIndex = 17;
            this.NaamLabel.Text = "<Naam Gebruiker>";
            // 
            // WinPercentageButton
            // 
            this.WinPercentageButton.Location = new System.Drawing.Point(456, 12);
            this.WinPercentageButton.Name = "WinPercentageButton";
            this.WinPercentageButton.Size = new System.Drawing.Size(165, 100);
            this.WinPercentageButton.TabIndex = 18;
            this.WinPercentageButton.Text = "<Win Percentage>";
            this.WinPercentageButton.UseVisualStyleBackColor = true;
            // 
            // LeavePercentageButton
            // 
            this.LeavePercentageButton.Location = new System.Drawing.Point(627, 12);
            this.LeavePercentageButton.Name = "LeavePercentageButton";
            this.LeavePercentageButton.Size = new System.Drawing.Size(165, 100);
            this.LeavePercentageButton.TabIndex = 19;
            this.LeavePercentageButton.Text = "<Leave Percentage>";
            this.LeavePercentageButton.UseVisualStyleBackColor = true;
            // 
            // BeschrijvingTekstbox
            // 
            this.BeschrijvingTekstbox.Location = new System.Drawing.Point(456, 119);
            this.BeschrijvingTekstbox.Name = "BeschrijvingTekstbox";
            this.BeschrijvingTekstbox.Size = new System.Drawing.Size(336, 252);
            this.BeschrijvingTekstbox.TabIndex = 20;
            this.BeschrijvingTekstbox.Text = "";
            // 
            // VerenigingButton
            // 
            this.VerenigingButton.Location = new System.Drawing.Point(9, 378);
            this.VerenigingButton.Name = "VerenigingButton";
            this.VerenigingButton.Size = new System.Drawing.Size(776, 60);
            this.VerenigingButton.TabIndex = 21;
            this.VerenigingButton.Text = "button1";
            this.VerenigingButton.UseVisualStyleBackColor = true;
            // 
            // Profiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerenigingButton);
            this.Controls.Add(this.BeschrijvingTekstbox);
            this.Controls.Add(this.LeavePercentageButton);
            this.Controls.Add(this.WinPercentageButton);
            this.Controls.Add(this.NaamLabel);
            this.Controls.Add(this.GebruikerPicturebox);
            this.Name = "Profiel";
            this.Text = "Profiel";
            ((System.ComponentModel.ISupportInitialize)(this.GebruikerPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GebruikerPicturebox;
        private System.Windows.Forms.Label NaamLabel;
        private System.Windows.Forms.Button WinPercentageButton;
        private System.Windows.Forms.Button LeavePercentageButton;
        private System.Windows.Forms.RichTextBox BeschrijvingTekstbox;
        private System.Windows.Forms.Button VerenigingButton;
    }
}