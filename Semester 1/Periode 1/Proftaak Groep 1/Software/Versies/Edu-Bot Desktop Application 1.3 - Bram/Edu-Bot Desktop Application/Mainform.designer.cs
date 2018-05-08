namespace EV3RemoteControlWifi
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
            this.label3 = new System.Windows.Forms.Label();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.clearReceivedMessagesButton = new System.Windows.Forms.Button();
            this.receivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.buttonMainformTerug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "IP addres van EV3";
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Location = new System.Drawing.Point(14, 37);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(243, 20);
            this.ipAddressBox.TabIndex = 11;
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel.Location = new System.Drawing.Point(262, 37);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(116, 56);
            this.connectedDeviceLabel.TabIndex = 10;
            this.connectedDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(14, 62);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(122, 31);
            this.disconnectButton.TabIndex = 9;
            this.disconnectButton.Text = "Loskoppelen";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.connectButton.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(142, 62);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(115, 31);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Verbinden";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // clearReceivedMessagesButton
            // 
            this.clearReceivedMessagesButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearReceivedMessagesButton.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearReceivedMessagesButton.Location = new System.Drawing.Point(385, 215);
            this.clearReceivedMessagesButton.Name = "clearReceivedMessagesButton";
            this.clearReceivedMessagesButton.Size = new System.Drawing.Size(256, 41);
            this.clearReceivedMessagesButton.TabIndex = 2;
            this.clearReceivedMessagesButton.Text = "Wis data";
            this.clearReceivedMessagesButton.UseVisualStyleBackColor = false;
            this.clearReceivedMessagesButton.Click += new System.EventHandler(this.clearReceivedMessagesButton_Click);
            // 
            // receivedMessagesListBox
            // 
            this.receivedMessagesListBox.FormattingEnabled = true;
            this.receivedMessagesListBox.Location = new System.Drawing.Point(384, 11);
            this.receivedMessagesListBox.Name = "receivedMessagesListBox";
            this.receivedMessagesListBox.Size = new System.Drawing.Size(257, 199);
            this.receivedMessagesListBox.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRead.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(10, 176);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(126, 31);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "lees inbox";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSend.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(142, 176);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(115, 31);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Upload";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(10, 152);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(248, 20);
            this.commandBox.TabIndex = 0;
            // 
            // buttonMainformTerug
            // 
            this.buttonMainformTerug.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMainformTerug.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainformTerug.Location = new System.Drawing.Point(10, 215);
            this.buttonMainformTerug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMainformTerug.Name = "buttonMainformTerug";
            this.buttonMainformTerug.Size = new System.Drawing.Size(98, 41);
            this.buttonMainformTerug.TabIndex = 8;
            this.buttonMainformTerug.Text = "Terug";
            this.buttonMainformTerug.UseVisualStyleBackColor = false;
            this.buttonMainformTerug.Click += new System.EventHandler(this.buttonMainformTerug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Upload data naar de EV3";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(872, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.clearReceivedMessagesButton);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.connectedDeviceLabel);
            this.Controls.Add(this.receivedMessagesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.buttonMainformTerug);
            this.Controls.Add(this.ipAddressBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Mainform";
            this.Text = "EV3 Remote Control Wifi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox receivedMessagesListBox;
        private System.Windows.Forms.Label connectedDeviceLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button clearReceivedMessagesButton;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipAddressBox;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button buttonMainformTerug;
        private System.Windows.Forms.Label label1;
    }
}

