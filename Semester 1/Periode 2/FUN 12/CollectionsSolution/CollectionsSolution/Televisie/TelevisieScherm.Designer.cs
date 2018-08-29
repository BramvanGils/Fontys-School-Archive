namespace Televisie
{
    partial class TelevisieScherm
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
            this.ButtonVoegZenderToe = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.PowerButton = new System.Windows.Forms.Button();
            this.Picturebox = new System.Windows.Forms.PictureBox();
            this.ZenderBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZenderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonVoegZenderToe
            // 
            this.ButtonVoegZenderToe.Location = new System.Drawing.Point(683, 64);
            this.ButtonVoegZenderToe.Name = "ButtonVoegZenderToe";
            this.ButtonVoegZenderToe.Size = new System.Drawing.Size(105, 23);
            this.ButtonVoegZenderToe.TabIndex = 0;
            this.ButtonVoegZenderToe.Text = "Voeg zender toe";
            this.ButtonVoegZenderToe.UseVisualStyleBackColor = true;
            this.ButtonVoegZenderToe.Click += new System.EventHandler(this.ButtonVoegZenderToe_Click);
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(683, 38);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(105, 20);
            this.Textbox.TabIndex = 1;
            // 
            // PowerButton
            // 
            this.PowerButton.Location = new System.Drawing.Point(683, 374);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(105, 35);
            this.PowerButton.TabIndex = 3;
            this.PowerButton.Text = "Uit";
            this.PowerButton.UseVisualStyleBackColor = true;
            this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // Picturebox
            // 
            this.Picturebox.Location = new System.Drawing.Point(13, 13);
            this.Picturebox.Name = "Picturebox";
            this.Picturebox.Size = new System.Drawing.Size(664, 396);
            this.Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picturebox.TabIndex = 5;
            this.Picturebox.TabStop = false;
            // 
            // ZenderBox
            // 
            this.ZenderBox.Location = new System.Drawing.Point(683, 12);
            this.ZenderBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.ZenderBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZenderBox.Name = "ZenderBox";
            this.ZenderBox.Size = new System.Drawing.Size(40, 20);
            this.ZenderBox.TabIndex = 6;
            this.ZenderBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZenderBox.ValueChanged += new System.EventHandler(this.ZenderBox_ValueChanged);
            // 
            // TelevisieScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 412);
            this.Controls.Add(this.ZenderBox);
            this.Controls.Add(this.Picturebox);
            this.Controls.Add(this.PowerButton);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.ButtonVoegZenderToe);
            this.Name = "TelevisieScherm";
            this.Text = "Televisie Scherm";
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZenderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonVoegZenderToe;
        private System.Windows.Forms.TextBox Textbox;
        private System.Windows.Forms.Button PowerButton;
        private System.Windows.Forms.PictureBox Picturebox;
        private System.Windows.Forms.NumericUpDown ZenderBox;
    }
}

