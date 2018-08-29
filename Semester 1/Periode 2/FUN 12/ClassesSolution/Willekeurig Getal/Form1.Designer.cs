namespace Willekeurig_Getal
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
            this.TextboxMin = new System.Windows.Forms.TextBox();
            this.TextboxMax = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.TextboxGebruiker = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextboxMin
            // 
            this.TextboxMin.Location = new System.Drawing.Point(13, 13);
            this.TextboxMin.Name = "TextboxMin";
            this.TextboxMin.Size = new System.Drawing.Size(100, 20);
            this.TextboxMin.TabIndex = 0;
            // 
            // TextboxMax
            // 
            this.TextboxMax.Location = new System.Drawing.Point(120, 12);
            this.TextboxMax.Name = "TextboxMax";
            this.TextboxMax.Size = new System.Drawing.Size(100, 20);
            this.TextboxMax.TabIndex = 1;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 39);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(208, 23);
            this.Button.TabIndex = 2;
            this.Button.Text = "Bereken willekeurig getal";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // TextboxGebruiker
            // 
            this.TextboxGebruiker.Location = new System.Drawing.Point(13, 69);
            this.TextboxGebruiker.Name = "TextboxGebruiker";
            this.TextboxGebruiker.Size = new System.Drawing.Size(207, 20);
            this.TextboxGebruiker.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 95);
            this.Controls.Add(this.TextboxGebruiker);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.TextboxMax);
            this.Controls.Add(this.TextboxMin);
            this.Name = "Form1";
            this.Text = "Willekeurig Getal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxMin;
        private System.Windows.Forms.TextBox TextboxMax;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox TextboxGebruiker;
    }
}

