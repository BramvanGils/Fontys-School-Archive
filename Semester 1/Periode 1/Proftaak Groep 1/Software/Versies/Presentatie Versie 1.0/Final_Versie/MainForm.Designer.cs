namespace Final_Versie
{
    partial class Mainform
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
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.buttonMainformTerug = new System.Windows.Forms.Button();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.ButtonStatestieken = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel.Location = new System.Drawing.Point(542, 620);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(798, 173);
            this.connectedDeviceLabel.TabIndex = 22;
            this.connectedDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 60F);
            this.label3.Location = new System.Drawing.Point(542, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(824, 93);
            this.label3.TabIndex = 24;
            this.label3.Text = "IP addres van EV3";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.connectButton.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(926, 512);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(414, 105);
            this.connectButton.TabIndex = 19;
            this.connectButton.Text = "Verbinden";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click_1);
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(542, 512);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(378, 105);
            this.disconnectButton.TabIndex = 21;
            this.disconnectButton.Text = "Loskoppelen";
            this.disconnectButton.UseVisualStyleBackColor = false;
            // 
            // buttonMainformTerug
            // 
            this.buttonMainformTerug.BackColor = System.Drawing.Color.Salmon;
            this.buttonMainformTerug.Font = new System.Drawing.Font("Felix Titling", 60F);
            this.buttonMainformTerug.Location = new System.Drawing.Point(950, 890);
            this.buttonMainformTerug.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMainformTerug.Name = "buttonMainformTerug";
            this.buttonMainformTerug.Size = new System.Drawing.Size(943, 140);
            this.buttonMainformTerug.TabIndex = 20;
            this.buttonMainformTerug.Text = "Afsluiten";
            this.buttonMainformTerug.UseVisualStyleBackColor = false;
            this.buttonMainformTerug.Click += new System.EventHandler(this.buttonMainformTerug_Click_1);
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.ipAddressBox.Location = new System.Drawing.Point(542, 408);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(798, 98);
            this.ipAddressBox.TabIndex = 23;
            // 
            // ButtonStatestieken
            // 
            this.ButtonStatestieken.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonStatestieken.Font = new System.Drawing.Font("Felix Titling", 60F);
            this.ButtonStatestieken.Location = new System.Drawing.Point(44, 890);
            this.ButtonStatestieken.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonStatestieken.Name = "ButtonStatestieken";
            this.ButtonStatestieken.Size = new System.Drawing.Size(902, 140);
            this.ButtonStatestieken.TabIndex = 26;
            this.ButtonStatestieken.Text = "Statistieken";
            this.ButtonStatestieken.UseVisualStyleBackColor = false;
            this.ButtonStatestieken.Click += new System.EventHandler(this.ButtonStatestieken_Click);
            // 
            // Title
            // 
            this.Title.Enabled = false;
            this.Title.Font = new System.Drawing.Font("Felix Titling", 60F);
            this.Title.Location = new System.Drawing.Point(12, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1880, 100);
            this.Title.TabIndex = 27;
            this.Title.Text = "Menu";
            this.Title.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ButtonStatestieken);
            this.Controls.Add(this.connectedDeviceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.buttonMainformTerug);
            this.Controls.Add(this.ipAddressBox);
            this.Name = "Mainform";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label connectedDeviceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button buttonMainformTerug;
        private System.Windows.Forms.TextBox ipAddressBox;
        private System.Windows.Forms.Button ButtonStatestieken;
        private System.Windows.Forms.Button Title;
    }
}