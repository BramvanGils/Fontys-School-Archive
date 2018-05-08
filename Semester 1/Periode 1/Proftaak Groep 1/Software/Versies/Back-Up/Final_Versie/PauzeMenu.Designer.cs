namespace Final_Versie
{
    partial class PauzeMenu
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
            this.buttonPauzemenuHoofdmenu = new System.Windows.Forms.Button();
            this.buttonPauzemenuInstellingen = new System.Windows.Forms.Button();
            this.buttonPauzemenuSpelen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPauzemenuHoofdmenu
            // 
            this.buttonPauzemenuHoofdmenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPauzemenuHoofdmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPauzemenuHoofdmenu.ForeColor = System.Drawing.Color.White;
            this.buttonPauzemenuHoofdmenu.Location = new System.Drawing.Point(347, 377);
            this.buttonPauzemenuHoofdmenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPauzemenuHoofdmenu.Name = "buttonPauzemenuHoofdmenu";
            this.buttonPauzemenuHoofdmenu.Size = new System.Drawing.Size(191, 78);
            this.buttonPauzemenuHoofdmenu.TabIndex = 10;
            this.buttonPauzemenuHoofdmenu.Text = "Hoofdmenu";
            this.buttonPauzemenuHoofdmenu.UseVisualStyleBackColor = false;
            this.buttonPauzemenuHoofdmenu.Click += new System.EventHandler(this.buttonPauzemenuHoofdmenu_Click);
            // 
            // buttonPauzemenuInstellingen
            // 
            this.buttonPauzemenuInstellingen.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPauzemenuInstellingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPauzemenuInstellingen.ForeColor = System.Drawing.Color.White;
            this.buttonPauzemenuInstellingen.Location = new System.Drawing.Point(347, 268);
            this.buttonPauzemenuInstellingen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPauzemenuInstellingen.Name = "buttonPauzemenuInstellingen";
            this.buttonPauzemenuInstellingen.Size = new System.Drawing.Size(191, 78);
            this.buttonPauzemenuInstellingen.TabIndex = 9;
            this.buttonPauzemenuInstellingen.Text = "Instellingen";
            this.buttonPauzemenuInstellingen.UseVisualStyleBackColor = false;
            this.buttonPauzemenuInstellingen.Click += new System.EventHandler(this.buttonPauzemenuInstellingen_Click);
            // 
            // buttonPauzemenuSpelen
            // 
            this.buttonPauzemenuSpelen.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPauzemenuSpelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPauzemenuSpelen.ForeColor = System.Drawing.Color.White;
            this.buttonPauzemenuSpelen.Location = new System.Drawing.Point(347, 157);
            this.buttonPauzemenuSpelen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPauzemenuSpelen.Name = "buttonPauzemenuSpelen";
            this.buttonPauzemenuSpelen.Size = new System.Drawing.Size(191, 78);
            this.buttonPauzemenuSpelen.TabIndex = 8;
            this.buttonPauzemenuSpelen.Text = "Doorgaan";
            this.buttonPauzemenuSpelen.UseVisualStyleBackColor = false;
            this.buttonPauzemenuSpelen.Click += new System.EventHandler(this.buttonPauzemenuSpelen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pauze";
            // 
            // PauzeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonPauzemenuHoofdmenu);
            this.Controls.Add(this.buttonPauzemenuInstellingen);
            this.Controls.Add(this.buttonPauzemenuSpelen);
            this.Controls.Add(this.label1);
            this.Name = "PauzeMenu";
            this.Text = "PauzeMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPauzemenuHoofdmenu;
        private System.Windows.Forms.Button buttonPauzemenuInstellingen;
        private System.Windows.Forms.Button buttonPauzemenuSpelen;
        private System.Windows.Forms.Label label1;
    }
}