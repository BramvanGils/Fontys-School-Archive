namespace Dagen_van_de_week
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(13, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 20);
            this.TextBox.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(13, 38);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(100, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "Vertaal naar Dag";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 74);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Dagen van de Week";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Button;
    }
}

