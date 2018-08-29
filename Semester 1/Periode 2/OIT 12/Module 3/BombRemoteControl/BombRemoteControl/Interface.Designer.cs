namespace BombRemoteControl
{
    partial class Interface
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ConnectStatusLabel = new System.Windows.Forms.Label();
            this.testlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(13, 13);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click_1);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(94, 13);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 394);
            this.listBox1.TabIndex = 2;
            // 
            // ConnectStatusLabel
            // 
            this.ConnectStatusLabel.AutoSize = true;
            this.ConnectStatusLabel.Location = new System.Drawing.Point(175, 18);
            this.ConnectStatusLabel.Name = "ConnectStatusLabel";
            this.ConnectStatusLabel.Size = new System.Drawing.Size(77, 13);
            this.ConnectStatusLabel.TabIndex = 3;
            this.ConnectStatusLabel.Text = "No connection";
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(258, 18);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(35, 13);
            this.testlabel.TabIndex = 4;
            this.testlabel.Text = "label1";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.ConnectStatusLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ConnectStatusLabel;
        private System.Windows.Forms.Label testlabel;
    }
}

