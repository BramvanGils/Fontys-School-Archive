namespace Final_Versie
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
            this.label1 = new System.Windows.Forms.Label();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.clearReceivedMessagesButton = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.receivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.buttonMainformTerug = new System.Windows.Forms.Button();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Upload data naar de EV3";
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(190, 297);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(248, 20);
            this.commandBox.TabIndex = 14;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRead.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(190, 321);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(126, 31);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "lees inbox";
            this.btnRead.UseVisualStyleBackColor = false;
            // 
            // clearReceivedMessagesButton
            // 
            this.clearReceivedMessagesButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearReceivedMessagesButton.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearReceivedMessagesButton.Location = new System.Drawing.Point(565, 360);
            this.clearReceivedMessagesButton.Name = "clearReceivedMessagesButton";
            this.clearReceivedMessagesButton.Size = new System.Drawing.Size(256, 41);
            this.clearReceivedMessagesButton.TabIndex = 18;
            this.clearReceivedMessagesButton.Text = "Wis data";
            this.clearReceivedMessagesButton.UseVisualStyleBackColor = false;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSend.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(322, 321);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(115, 31);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "Upload";
            this.buttonSend.UseVisualStyleBackColor = false;
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel.Location = new System.Drawing.Point(442, 182);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(116, 56);
            this.connectedDeviceLabel.TabIndex = 22;
            this.connectedDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receivedMessagesListBox
            // 
            this.receivedMessagesListBox.FormattingEnabled = true;
            this.receivedMessagesListBox.Location = new System.Drawing.Point(564, 156);
            this.receivedMessagesListBox.Name = "receivedMessagesListBox";
            this.receivedMessagesListBox.Size = new System.Drawing.Size(257, 199);
            this.receivedMessagesListBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "IP addres van EV3";
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.connectButton.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(322, 207);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(115, 31);
            this.connectButton.TabIndex = 19;
            this.connectButton.Text = "Verbinden";
            this.connectButton.UseVisualStyleBackColor = false;
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(194, 207);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(122, 31);
            this.disconnectButton.TabIndex = 21;
            this.disconnectButton.Text = "Loskoppelen";
            this.disconnectButton.UseVisualStyleBackColor = false;
            // 
            // buttonMainformTerug
            // 
            this.buttonMainformTerug.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMainformTerug.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainformTerug.Location = new System.Drawing.Point(190, 360);
            this.buttonMainformTerug.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMainformTerug.Name = "buttonMainformTerug";
            this.buttonMainformTerug.Size = new System.Drawing.Size(98, 41);
            this.buttonMainformTerug.TabIndex = 20;
            this.buttonMainformTerug.Text = "Terug";
            this.buttonMainformTerug.UseVisualStyleBackColor = false;
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Location = new System.Drawing.Point(194, 182);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(243, 20);
            this.ipAddressBox.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 552);
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
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button clearReceivedMessagesButton;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label connectedDeviceLabel;
        private System.Windows.Forms.ListBox receivedMessagesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button buttonMainformTerug;
        private System.Windows.Forms.TextBox ipAddressBox;
    }
}