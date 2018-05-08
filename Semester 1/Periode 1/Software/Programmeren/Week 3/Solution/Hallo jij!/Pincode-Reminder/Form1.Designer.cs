namespace Pincode_Reminder
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
            this.LabelGebruikersnaam = new System.Windows.Forms.Label();
            this.LabelWachtwoord = new System.Windows.Forms.Label();
            this.TextBoxGebruikersnaam = new System.Windows.Forms.TextBox();
            this.TextBoxWachtwoord = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.LabelGoed = new System.Windows.Forms.Label();
            this.LabelFout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelGebruikersnaam
            // 
            this.LabelGebruikersnaam.AutoSize = true;
            this.LabelGebruikersnaam.Location = new System.Drawing.Point(13, 16);
            this.LabelGebruikersnaam.Name = "LabelGebruikersnaam";
            this.LabelGebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.LabelGebruikersnaam.TabIndex = 0;
            this.LabelGebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // LabelWachtwoord
            // 
            this.LabelWachtwoord.AutoSize = true;
            this.LabelWachtwoord.Location = new System.Drawing.Point(12, 42);
            this.LabelWachtwoord.Name = "LabelWachtwoord";
            this.LabelWachtwoord.Size = new System.Drawing.Size(63, 13);
            this.LabelWachtwoord.TabIndex = 1;
            this.LabelWachtwoord.Text = "Wachtoord:";
            // 
            // TextBoxGebruikersnaam
            // 
            this.TextBoxGebruikersnaam.Location = new System.Drawing.Point(106, 13);
            this.TextBoxGebruikersnaam.Name = "TextBoxGebruikersnaam";
            this.TextBoxGebruikersnaam.Size = new System.Drawing.Size(140, 20);
            this.TextBoxGebruikersnaam.TabIndex = 2;
            // 
            // TextBoxWachtwoord
            // 
            this.TextBoxWachtwoord.Location = new System.Drawing.Point(106, 39);
            this.TextBoxWachtwoord.Name = "TextBoxWachtwoord";
            this.TextBoxWachtwoord.PasswordChar = '*';
            this.TextBoxWachtwoord.Size = new System.Drawing.Size(140, 20);
            this.TextBoxWachtwoord.TabIndex = 3;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(264, 24);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(88, 23);
            this.Button.TabIndex = 4;
            this.Button.Text = "Toon Pincode";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // LabelGoed
            // 
            this.LabelGoed.AutoSize = true;
            this.LabelGoed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGoed.Location = new System.Drawing.Point(16, 78);
            this.LabelGoed.Name = "LabelGoed";
            this.LabelGoed.Size = new System.Drawing.Size(296, 20);
            this.LabelGoed.TabIndex = 6;
            this.LabelGoed.Text = "Wachtwoord correct, de pincode is: 4900";
            this.LabelGoed.Visible = false;
            // 
            // LabelFout
            // 
            this.LabelFout.AutoSize = true;
            this.LabelFout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFout.ForeColor = System.Drawing.Color.Red;
            this.LabelFout.Location = new System.Drawing.Point(16, 98);
            this.LabelFout.Name = "LabelFout";
            this.LabelFout.Size = new System.Drawing.Size(338, 20);
            this.LabelFout.TabIndex = 7;
            this.LabelFout.Text = "Wachtwoord niet correct, probeer het opnieuw.";
            this.LabelFout.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 127);
            this.Controls.Add(this.LabelFout);
            this.Controls.Add(this.LabelGoed);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.TextBoxWachtwoord);
            this.Controls.Add(this.TextBoxGebruikersnaam);
            this.Controls.Add(this.LabelWachtwoord);
            this.Controls.Add(this.LabelGebruikersnaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGebruikersnaam;
        private System.Windows.Forms.Label LabelWachtwoord;
        private System.Windows.Forms.TextBox TextBoxGebruikersnaam;
        private System.Windows.Forms.TextBox TextBoxWachtwoord;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label LabelGoed;
        private System.Windows.Forms.Label LabelFout;
    }
}

