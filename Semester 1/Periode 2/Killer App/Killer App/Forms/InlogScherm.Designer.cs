namespace Killer_App.Forms
{
    partial class InlogScherm
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
            this.WachtwoordTextbox = new System.Windows.Forms.TextBox();
            this.GebruikersnaamTextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.RegistreerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WachtwoordTextbox
            // 
            this.WachtwoordTextbox.Location = new System.Drawing.Point(105, 37);
            this.WachtwoordTextbox.Name = "WachtwoordTextbox";
            this.WachtwoordTextbox.PasswordChar = '*';
            this.WachtwoordTextbox.Size = new System.Drawing.Size(206, 20);
            this.WachtwoordTextbox.TabIndex = 0;
            // 
            // GebruikersnaamTextbox
            // 
            this.GebruikersnaamTextbox.Location = new System.Drawing.Point(105, 6);
            this.GebruikersnaamTextbox.Name = "GebruikersnaamTextbox";
            this.GebruikersnaamTextbox.Size = new System.Drawing.Size(206, 20);
            this.GebruikersnaamTextbox.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(105, 64);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(45, 97);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel.TabIndex = 3;
            this.ErrorLabel.Text = "ErrorLabel";
            this.ErrorLabel.Visible = false;
            // 
            // RegistreerButton
            // 
            this.RegistreerButton.Location = new System.Drawing.Point(211, 64);
            this.RegistreerButton.Name = "RegistreerButton";
            this.RegistreerButton.Size = new System.Drawing.Size(100, 23);
            this.RegistreerButton.TabIndex = 6;
            this.RegistreerButton.Text = "Registreer";
            this.RegistreerButton.UseVisualStyleBackColor = true;
            this.RegistreerButton.Click += new System.EventHandler(this.RegistreerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gebruikersnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wachtwoord:";
            // 
            // InlogScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 123);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistreerButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.GebruikersnaamTextbox);
            this.Controls.Add(this.WachtwoordTextbox);
            this.Name = "InlogScherm";
            this.Text = "InlogScherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WachtwoordTextbox;
        private System.Windows.Forms.TextBox GebruikersnaamTextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button RegistreerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}