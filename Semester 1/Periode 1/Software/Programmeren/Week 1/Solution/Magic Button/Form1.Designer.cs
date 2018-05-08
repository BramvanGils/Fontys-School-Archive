namespace Magic_Button
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
            this.magicbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // magicbutton
            // 
            this.magicbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.magicbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicbutton.ForeColor = System.Drawing.Color.White;
            this.magicbutton.Location = new System.Drawing.Point(12, 12);
            this.magicbutton.Name = "magicbutton";
            this.magicbutton.Size = new System.Drawing.Size(311, 237);
            this.magicbutton.TabIndex = 0;
            this.magicbutton.Text = "Magic";
            this.magicbutton.UseVisualStyleBackColor = false;
            this.magicbutton.Click += new System.EventHandler(this.magicbutton_Click);
            this.magicbutton.MouseHover += new System.EventHandler(this.magicbutton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.Controls.Add(this.magicbutton);
            this.Name = "Form1";
            this.Text = "The Domain of the Magic Button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button magicbutton;
    }
}

