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
            this.WachtwoordTextboxLogin = new System.Windows.Forms.TextBox();
            this.GebruikersnaamTextboxLogin = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ErrorLabel1 = new System.Windows.Forms.Label();
            this.ErrorLabel2 = new System.Windows.Forms.Label();
            this.RegistreerButton = new System.Windows.Forms.Button();
            this.GebruikersnaamTextboxRegistreer = new System.Windows.Forms.TextBox();
            this.WachtwoordTextboxRegistreer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WachtwoordTextboxLogin
            // 
            this.WachtwoordTextboxLogin.Location = new System.Drawing.Point(200, 218);
            this.WachtwoordTextboxLogin.Name = "WachtwoordTextboxLogin";
            this.WachtwoordTextboxLogin.Size = new System.Drawing.Size(100, 20);
            this.WachtwoordTextboxLogin.TabIndex = 0;
            // 
            // GebruikersnaamTextboxLogin
            // 
            this.GebruikersnaamTextboxLogin.Location = new System.Drawing.Point(200, 187);
            this.GebruikersnaamTextboxLogin.Name = "GebruikersnaamTextboxLogin";
            this.GebruikersnaamTextboxLogin.Size = new System.Drawing.Size(100, 20);
            this.GebruikersnaamTextboxLogin.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(200, 245);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel1
            // 
            this.ErrorLabel1.AutoSize = true;
            this.ErrorLabel1.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel1.Location = new System.Drawing.Point(200, 275);
            this.ErrorLabel1.Name = "ErrorLabel1";
            this.ErrorLabel1.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel1.TabIndex = 3;
            this.ErrorLabel1.Text = "ErrorLabel";
            this.ErrorLabel1.Visible = false;
            // 
            // ErrorLabel2
            // 
            this.ErrorLabel2.AutoSize = true;
            this.ErrorLabel2.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel2.Location = new System.Drawing.Point(451, 275);
            this.ErrorLabel2.Name = "ErrorLabel2";
            this.ErrorLabel2.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel2.TabIndex = 7;
            this.ErrorLabel2.Text = "ErrorLabel";
            this.ErrorLabel2.Visible = false;
            // 
            // RegistreerButton
            // 
            this.RegistreerButton.Location = new System.Drawing.Point(451, 245);
            this.RegistreerButton.Name = "RegistreerButton";
            this.RegistreerButton.Size = new System.Drawing.Size(100, 23);
            this.RegistreerButton.TabIndex = 6;
            this.RegistreerButton.Text = "Registreer";
            this.RegistreerButton.UseVisualStyleBackColor = true;
            // 
            // GebruikersnaamTextboxRegistreer
            // 
            this.GebruikersnaamTextboxRegistreer.Location = new System.Drawing.Point(451, 187);
            this.GebruikersnaamTextboxRegistreer.Name = "GebruikersnaamTextboxRegistreer";
            this.GebruikersnaamTextboxRegistreer.Size = new System.Drawing.Size(100, 20);
            this.GebruikersnaamTextboxRegistreer.TabIndex = 5;
            // 
            // WachtwoordTextboxRegistreer
            // 
            this.WachtwoordTextboxRegistreer.Location = new System.Drawing.Point(451, 218);
            this.WachtwoordTextboxRegistreer.Name = "WachtwoordTextboxRegistreer";
            this.WachtwoordTextboxRegistreer.Size = new System.Drawing.Size(100, 20);
            this.WachtwoordTextboxRegistreer.TabIndex = 4;
            // 
            // InlogScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.ErrorLabel2);
            this.Controls.Add(this.RegistreerButton);
            this.Controls.Add(this.GebruikersnaamTextboxRegistreer);
            this.Controls.Add(this.WachtwoordTextboxRegistreer);
            this.Controls.Add(this.ErrorLabel1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.GebruikersnaamTextboxLogin);
            this.Controls.Add(this.WachtwoordTextboxLogin);
            this.Name = "InlogScherm";
            this.Text = "InlogScherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WachtwoordTextboxLogin;
        private System.Windows.Forms.TextBox GebruikersnaamTextboxLogin;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ErrorLabel1;
        private System.Windows.Forms.Label ErrorLabel2;
        private System.Windows.Forms.Button RegistreerButton;
        private System.Windows.Forms.TextBox GebruikersnaamTextboxRegistreer;
        private System.Windows.Forms.TextBox WachtwoordTextboxRegistreer;
    }
}