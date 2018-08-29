namespace RandomWoordGenerator
{
    partial class InputForm
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
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(13, 39);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(100, 23);
            this.Button.TabIndex = 0;
            this.Button.Text = "Genereer";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(13, 13);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(100, 20);
            this.Textbox.TabIndex = 1;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(129, 77);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.Button);
            this.Name = "InputForm";
            this.Text = "RandomWoordGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox Textbox;
    }
}

