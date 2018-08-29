namespace TekstPlakker
{
    partial class MainForm
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
            this.TextboxOutput = new System.Windows.Forms.TextBox();
            this.TextboxInput = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.Numericupdown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Numericupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // TextboxOutput
            // 
            this.TextboxOutput.Location = new System.Drawing.Point(119, 38);
            this.TextboxOutput.Multiline = true;
            this.TextboxOutput.Name = "TextboxOutput";
            this.TextboxOutput.Size = new System.Drawing.Size(100, 220);
            this.TextboxOutput.TabIndex = 1;
            // 
            // TextboxInput
            // 
            this.TextboxInput.Location = new System.Drawing.Point(119, 12);
            this.TextboxInput.Name = "TextboxInput";
            this.TextboxInput.Size = new System.Drawing.Size(100, 20);
            this.TextboxInput.TabIndex = 2;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(13, 12);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(100, 23);
            this.Button.TabIndex = 3;
            this.Button.Text = "Voeg toe";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Numericupdown
            // 
            this.Numericupdown.Location = new System.Drawing.Point(13, 42);
            this.Numericupdown.Name = "Numericupdown";
            this.Numericupdown.Size = new System.Drawing.Size(100, 20);
            this.Numericupdown.TabIndex = 4;
            this.Numericupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 261);
            this.Controls.Add(this.Numericupdown);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.TextboxInput);
            this.Controls.Add(this.TextboxOutput);
            this.Name = "MainForm";
            this.Text = "TekstPlakker";
            ((System.ComponentModel.ISupportInitialize)(this.Numericupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxOutput;
        private System.Windows.Forms.TextBox TextboxInput;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.NumericUpDown Numericupdown;
    }
}

