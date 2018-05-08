namespace De_drie_Vierkanten
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
            this.LabelVierkant1 = new System.Windows.Forms.Label();
            this.TextboxVierkant1 = new System.Windows.Forms.TextBox();
            this.TextboxVierkant2 = new System.Windows.Forms.TextBox();
            this.LabelVierkant2 = new System.Windows.Forms.Label();
            this.TextboxVierkant3 = new System.Windows.Forms.TextBox();
            this.LabelVierkant3 = new System.Windows.Forms.Label();
            this.ButtonBereken = new System.Windows.Forms.Button();
            this.LabelAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelVierkant1
            // 
            this.LabelVierkant1.AutoSize = true;
            this.LabelVierkant1.Location = new System.Drawing.Point(13, 13);
            this.LabelVierkant1.Name = "LabelVierkant1";
            this.LabelVierkant1.Size = new System.Drawing.Size(90, 13);
            this.LabelVierkant1.TabIndex = 0;
            this.LabelVierkant1.Text = "Lengte vierkant 1";
            // 
            // TextboxVierkant1
            // 
            this.TextboxVierkant1.Location = new System.Drawing.Point(13, 30);
            this.TextboxVierkant1.Name = "TextboxVierkant1";
            this.TextboxVierkant1.Size = new System.Drawing.Size(100, 20);
            this.TextboxVierkant1.TabIndex = 1;
            // 
            // TextboxVierkant2
            // 
            this.TextboxVierkant2.Location = new System.Drawing.Point(119, 30);
            this.TextboxVierkant2.Name = "TextboxVierkant2";
            this.TextboxVierkant2.Size = new System.Drawing.Size(100, 20);
            this.TextboxVierkant2.TabIndex = 3;
            // 
            // LabelVierkant2
            // 
            this.LabelVierkant2.AutoSize = true;
            this.LabelVierkant2.Location = new System.Drawing.Point(119, 13);
            this.LabelVierkant2.Name = "LabelVierkant2";
            this.LabelVierkant2.Size = new System.Drawing.Size(90, 13);
            this.LabelVierkant2.TabIndex = 2;
            this.LabelVierkant2.Text = "Lengte vierkant 2";
            // 
            // TextboxVierkant3
            // 
            this.TextboxVierkant3.Location = new System.Drawing.Point(225, 30);
            this.TextboxVierkant3.Name = "TextboxVierkant3";
            this.TextboxVierkant3.Size = new System.Drawing.Size(100, 20);
            this.TextboxVierkant3.TabIndex = 5;
            // 
            // LabelVierkant3
            // 
            this.LabelVierkant3.AutoSize = true;
            this.LabelVierkant3.Location = new System.Drawing.Point(225, 13);
            this.LabelVierkant3.Name = "LabelVierkant3";
            this.LabelVierkant3.Size = new System.Drawing.Size(90, 13);
            this.LabelVierkant3.TabIndex = 4;
            this.LabelVierkant3.Text = "Lengte vierkant 3";
            // 
            // ButtonBereken
            // 
            this.ButtonBereken.Location = new System.Drawing.Point(13, 56);
            this.ButtonBereken.Name = "ButtonBereken";
            this.ButtonBereken.Size = new System.Drawing.Size(75, 23);
            this.ButtonBereken.TabIndex = 6;
            this.ButtonBereken.Text = "Bereken";
            this.ButtonBereken.UseVisualStyleBackColor = true;
            this.ButtonBereken.Click += new System.EventHandler(this.ButtonBereken_Click);
            // 
            // LabelAntwoord
            // 
            this.LabelAntwoord.AutoSize = true;
            this.LabelAntwoord.Location = new System.Drawing.Point(13, 82);
            this.LabelAntwoord.Name = "LabelAntwoord";
            this.LabelAntwoord.Size = new System.Drawing.Size(0, 13);
            this.LabelAntwoord.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 114);
            this.Controls.Add(this.LabelAntwoord);
            this.Controls.Add(this.ButtonBereken);
            this.Controls.Add(this.TextboxVierkant3);
            this.Controls.Add(this.LabelVierkant3);
            this.Controls.Add(this.TextboxVierkant2);
            this.Controls.Add(this.LabelVierkant2);
            this.Controls.Add(this.TextboxVierkant1);
            this.Controls.Add(this.LabelVierkant1);
            this.Name = "Form1";
            this.Text = "De drie vierkanten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelVierkant1;
        private System.Windows.Forms.TextBox TextboxVierkant1;
        private System.Windows.Forms.TextBox TextboxVierkant2;
        private System.Windows.Forms.Label LabelVierkant2;
        private System.Windows.Forms.TextBox TextboxVierkant3;
        private System.Windows.Forms.Label LabelVierkant3;
        private System.Windows.Forms.Button ButtonBereken;
        private System.Windows.Forms.Label LabelAntwoord;
    }
}

