namespace Woorden_Lijst
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
            this.Button = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.Numericupdown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Numericupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 37);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(157, 23);
            this.Button.TabIndex = 0;
            this.Button.Text = "geef weer";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(12, 13);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(100, 20);
            this.Textbox.TabIndex = 1;
            // 
            // Numericupdown
            // 
            this.Numericupdown.Location = new System.Drawing.Point(119, 13);
            this.Numericupdown.Name = "Numericupdown";
            this.Numericupdown.Size = new System.Drawing.Size(50, 20);
            this.Numericupdown.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 72);
            this.Controls.Add(this.Numericupdown);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Numericupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox Textbox;
        private System.Windows.Forms.NumericUpDown Numericupdown;
    }
}

