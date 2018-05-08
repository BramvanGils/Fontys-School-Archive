namespace Tafel_van_Drie
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
            this.Listbox = new System.Windows.Forms.ListBox();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.Location = new System.Drawing.Point(12, 13);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(205, 238);
            this.Listbox.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(12, 257);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "Bereken Tafel";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 287);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Listbox);
            this.Name = "Form1";
            this.Text = "Tafel van Drie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.Button Button;
    }
}

