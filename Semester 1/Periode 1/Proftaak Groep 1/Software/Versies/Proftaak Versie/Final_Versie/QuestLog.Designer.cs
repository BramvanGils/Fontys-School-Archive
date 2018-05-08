namespace Final_Versie
{
    partial class QuestLog
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
            this.buttonInventarisvolgendepagina = new System.Windows.Forms.Button();
            this.buttonInventarisVorigepagina = new System.Windows.Forms.Button();
            this.labelInventarisTitel = new System.Windows.Forms.Label();
            this.buttonStatestiekenTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInventarisvolgendepagina
            // 
            this.buttonInventarisvolgendepagina.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonInventarisvolgendepagina.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventarisvolgendepagina.ForeColor = System.Drawing.Color.White;
            this.buttonInventarisvolgendepagina.Location = new System.Drawing.Point(693, 11);
            this.buttonInventarisvolgendepagina.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInventarisvolgendepagina.Name = "buttonInventarisvolgendepagina";
            this.buttonInventarisvolgendepagina.Size = new System.Drawing.Size(65, 51);
            this.buttonInventarisvolgendepagina.TabIndex = 52;
            this.buttonInventarisvolgendepagina.Text = ">";
            this.buttonInventarisvolgendepagina.UseVisualStyleBackColor = false;
            this.buttonInventarisvolgendepagina.Click += new System.EventHandler(this.buttonInventarisvolgendepagina_Click);
            // 
            // buttonInventarisVorigepagina
            // 
            this.buttonInventarisVorigepagina.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonInventarisVorigepagina.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventarisVorigepagina.ForeColor = System.Drawing.Color.White;
            this.buttonInventarisVorigepagina.Location = new System.Drawing.Point(176, 11);
            this.buttonInventarisVorigepagina.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInventarisVorigepagina.Name = "buttonInventarisVorigepagina";
            this.buttonInventarisVorigepagina.Size = new System.Drawing.Size(65, 51);
            this.buttonInventarisVorigepagina.TabIndex = 51;
            this.buttonInventarisVorigepagina.Text = "<";
            this.buttonInventarisVorigepagina.UseVisualStyleBackColor = false;
            this.buttonInventarisVorigepagina.Click += new System.EventHandler(this.buttonInventarisVorigepagina_Click);
            // 
            // labelInventarisTitel
            // 
            this.labelInventarisTitel.AutoSize = true;
            this.labelInventarisTitel.BackColor = System.Drawing.Color.SteelBlue;
            this.labelInventarisTitel.Font = new System.Drawing.Font("Felix Titling", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventarisTitel.ForeColor = System.Drawing.Color.White;
            this.labelInventarisTitel.Location = new System.Drawing.Point(362, 13);
            this.labelInventarisTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventarisTitel.Name = "labelInventarisTitel";
            this.labelInventarisTitel.Size = new System.Drawing.Size(194, 38);
            this.labelInventarisTitel.TabIndex = 50;
            this.labelInventarisTitel.Text = "Quest Log";
            // 
            // buttonStatestiekenTerug
            // 
            this.buttonStatestiekenTerug.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonStatestiekenTerug.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatestiekenTerug.ForeColor = System.Drawing.Color.White;
            this.buttonStatestiekenTerug.Location = new System.Drawing.Point(672, 370);
            this.buttonStatestiekenTerug.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStatestiekenTerug.Name = "buttonStatestiekenTerug";
            this.buttonStatestiekenTerug.Size = new System.Drawing.Size(86, 46);
            this.buttonStatestiekenTerug.TabIndex = 53;
            this.buttonStatestiekenTerug.Text = "Terug";
            this.buttonStatestiekenTerug.UseVisualStyleBackColor = false;
            this.buttonStatestiekenTerug.Click += new System.EventHandler(this.buttonStatestiekenTerug_Click);
            // 
            // QuestLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 597);
            this.Controls.Add(this.buttonStatestiekenTerug);
            this.Controls.Add(this.buttonInventarisvolgendepagina);
            this.Controls.Add(this.buttonInventarisVorigepagina);
            this.Controls.Add(this.labelInventarisTitel);
            this.Name = "QuestLog";
            this.Text = "QuestLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInventarisvolgendepagina;
        private System.Windows.Forms.Button buttonInventarisVorigepagina;
        private System.Windows.Forms.Label labelInventarisTitel;
        private System.Windows.Forms.Button buttonStatestiekenTerug;
    }
}