namespace pauzemenu
{
    partial class Pauzemenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPauzemenuSpelen = new System.Windows.Forms.Button();
            this.buttonPauzemenuInstellingen = new System.Windows.Forms.Button();
            this.buttonPauzemenuHoofdmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pauze";
            // 
            // buttonPauzemenuSpelen
            // 
            this.buttonPauzemenuSpelen.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPauzemenuSpelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPauzemenuSpelen.ForeColor = System.Drawing.Color.White;
            this.buttonPauzemenuSpelen.Location = new System.Drawing.Point(268, 72);
            this.buttonPauzemenuSpelen.Name = "buttonPauzemenuSpelen";
            this.buttonPauzemenuSpelen.Size = new System.Drawing.Size(255, 96);
            this.buttonPauzemenuSpelen.TabIndex = 4;
            this.buttonPauzemenuSpelen.Text = "Spelen";
            this.buttonPauzemenuSpelen.UseVisualStyleBackColor = false;
            // 
            // buttonPauzemenuInstellingen
            // 
            this.buttonPauzemenuInstellingen.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPauzemenuInstellingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPauzemenuInstellingen.ForeColor = System.Drawing.Color.White;
            this.buttonPauzemenuInstellingen.Location = new System.Drawing.Point(268, 208);
            this.buttonPauzemenuInstellingen.Name = "buttonPauzemenuInstellingen";
            this.buttonPauzemenuInstellingen.Size = new System.Drawing.Size(255, 96);
            this.buttonPauzemenuInstellingen.TabIndex = 5;
            this.buttonPauzemenuInstellingen.Text = "Instellingen";
            this.buttonPauzemenuInstellingen.UseVisualStyleBackColor = false;
            // 
            // buttonPauzemenuHoofdmenu
            // 
            this.buttonPauzemenuHoofdmenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPauzemenuHoofdmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPauzemenuHoofdmenu.ForeColor = System.Drawing.Color.White;
            this.buttonPauzemenuHoofdmenu.Location = new System.Drawing.Point(268, 342);
            this.buttonPauzemenuHoofdmenu.Name = "buttonPauzemenuHoofdmenu";
            this.buttonPauzemenuHoofdmenu.Size = new System.Drawing.Size(255, 96);
            this.buttonPauzemenuHoofdmenu.TabIndex = 6;
            this.buttonPauzemenuHoofdmenu.Text = "Hoofdmenu";
            this.buttonPauzemenuHoofdmenu.UseVisualStyleBackColor = false;
            // 
            // Pauzemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPauzemenuHoofdmenu);
            this.Controls.Add(this.buttonPauzemenuInstellingen);
            this.Controls.Add(this.buttonPauzemenuSpelen);
            this.Controls.Add(this.label1);
            this.Name = "Pauzemenu";
            this.Text = "Pauze menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPauzemenuSpelen;
        private System.Windows.Forms.Button buttonPauzemenuInstellingen;
        private System.Windows.Forms.Button buttonPauzemenuHoofdmenu;
    }
}

