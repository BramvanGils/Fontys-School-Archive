namespace Woorden_Lijst
{
    partial class ListForm
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
            this.SuspendLayout();
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.Location = new System.Drawing.Point(13, 13);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(205, 238);
            this.Listbox.TabIndex = 0;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 261);
            this.Controls.Add(this.Listbox);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Listbox;
    }
}