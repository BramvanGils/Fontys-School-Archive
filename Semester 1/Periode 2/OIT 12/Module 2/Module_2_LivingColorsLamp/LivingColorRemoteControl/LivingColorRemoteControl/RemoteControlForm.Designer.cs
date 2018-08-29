namespace LivingColorRemoteControl
{
    partial class RemoteControlForm
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
            this.redSlider = new System.Windows.Forms.TrackBar();
            this.greenSlider = new System.Windows.Forms.TrackBar();
            this.blueSlider = new System.Windows.Forms.TrackBar();
            this.redSliderLabel = new System.Windows.Forms.Label();
            this.greenSliderLabel = new System.Windows.Forms.Label();
            this.blueSliderLabel = new System.Windows.Forms.Label();
            this.controlFromPCButton = new System.Windows.Forms.Button();
            this.pcColorPanel = new System.Windows.Forms.Panel();
            this.remoteControlGroupBox = new System.Windows.Forms.GroupBox();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.whoIsInControlLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.disconnecButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.arduinoBlueTextBox = new System.Windows.Forms.TextBox();
            this.arduinoColorPanel = new System.Windows.Forms.Panel();
            this.arduinoGreenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arduinoRedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).BeginInit();
            this.remoteControlGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // redSlider
            // 
            this.redSlider.Location = new System.Drawing.Point(6, 46);
            this.redSlider.Maximum = 255;
            this.redSlider.Name = "redSlider";
            this.redSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redSlider.Size = new System.Drawing.Size(56, 324);
            this.redSlider.TabIndex = 0;
            this.redSlider.TickFrequency = 5;
            this.redSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.redSlider.Scroll += new System.EventHandler(this.redSlider_Scroll);
            // 
            // greenSlider
            // 
            this.greenSlider.Location = new System.Drawing.Point(68, 46);
            this.greenSlider.Maximum = 255;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenSlider.Size = new System.Drawing.Size(56, 324);
            this.greenSlider.TabIndex = 0;
            this.greenSlider.TickFrequency = 5;
            this.greenSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.greenSlider.Scroll += new System.EventHandler(this.greenSlider_Scroll);
            // 
            // blueSlider
            // 
            this.blueSlider.Location = new System.Drawing.Point(130, 46);
            this.blueSlider.Maximum = 255;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueSlider.Size = new System.Drawing.Size(56, 324);
            this.blueSlider.TabIndex = 0;
            this.blueSlider.TickFrequency = 5;
            this.blueSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.blueSlider.Scroll += new System.EventHandler(this.blueSlider_Scroll);
            // 
            // redSliderLabel
            // 
            this.redSliderLabel.AutoSize = true;
            this.redSliderLabel.Location = new System.Drawing.Point(12, 373);
            this.redSliderLabel.Name = "redSliderLabel";
            this.redSliderLabel.Size = new System.Drawing.Size(34, 17);
            this.redSliderLabel.TabIndex = 1;
            this.redSliderLabel.Text = "Red";
            // 
            // greenSliderLabel
            // 
            this.greenSliderLabel.AutoSize = true;
            this.greenSliderLabel.Location = new System.Drawing.Point(65, 373);
            this.greenSliderLabel.Name = "greenSliderLabel";
            this.greenSliderLabel.Size = new System.Drawing.Size(48, 17);
            this.greenSliderLabel.TabIndex = 1;
            this.greenSliderLabel.Text = "Green";
            // 
            // blueSliderLabel
            // 
            this.blueSliderLabel.AutoSize = true;
            this.blueSliderLabel.Location = new System.Drawing.Point(136, 373);
            this.blueSliderLabel.Name = "blueSliderLabel";
            this.blueSliderLabel.Size = new System.Drawing.Size(36, 17);
            this.blueSliderLabel.TabIndex = 1;
            this.blueSliderLabel.Text = "Blue";
            // 
            // controlFromPCButton
            // 
            this.controlFromPCButton.Location = new System.Drawing.Point(225, 30);
            this.controlFromPCButton.Name = "controlFromPCButton";
            this.controlFromPCButton.Size = new System.Drawing.Size(135, 35);
            this.controlFromPCButton.TabIndex = 2;
            this.controlFromPCButton.Text = "Control from PC";
            this.controlFromPCButton.UseVisualStyleBackColor = true;
            this.controlFromPCButton.Click += new System.EventHandler(this.controlFromPCButton_Click);
            // 
            // pcColorPanel
            // 
            this.pcColorPanel.BackColor = System.Drawing.Color.Black;
            this.pcColorPanel.Location = new System.Drawing.Point(192, 95);
            this.pcColorPanel.Name = "pcColorPanel";
            this.pcColorPanel.Size = new System.Drawing.Size(168, 110);
            this.pcColorPanel.TabIndex = 3;
            // 
            // remoteControlGroupBox
            // 
            this.remoteControlGroupBox.Controls.Add(this.blueTextBox);
            this.remoteControlGroupBox.Controls.Add(this.greenTextBox);
            this.remoteControlGroupBox.Controls.Add(this.redTextBox);
            this.remoteControlGroupBox.Controls.Add(this.pcColorPanel);
            this.remoteControlGroupBox.Controls.Add(this.greenSlider);
            this.remoteControlGroupBox.Controls.Add(this.redSlider);
            this.remoteControlGroupBox.Controls.Add(this.blueSlider);
            this.remoteControlGroupBox.Controls.Add(this.blueSliderLabel);
            this.remoteControlGroupBox.Controls.Add(this.redSliderLabel);
            this.remoteControlGroupBox.Controls.Add(this.greenSliderLabel);
            this.remoteControlGroupBox.Location = new System.Drawing.Point(12, 108);
            this.remoteControlGroupBox.Name = "remoteControlGroupBox";
            this.remoteControlGroupBox.Size = new System.Drawing.Size(373, 430);
            this.remoteControlGroupBox.TabIndex = 4;
            this.remoteControlGroupBox.TabStop = false;
            this.remoteControlGroupBox.Text = "Control the color from the PC";
            // 
            // blueTextBox
            // 
            this.blueTextBox.Enabled = false;
            this.blueTextBox.Location = new System.Drawing.Point(130, 393);
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(40, 22);
            this.blueTextBox.TabIndex = 4;
            // 
            // greenTextBox
            // 
            this.greenTextBox.Enabled = false;
            this.greenTextBox.Location = new System.Drawing.Point(68, 393);
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(40, 22);
            this.greenTextBox.TabIndex = 4;
            // 
            // redTextBox
            // 
            this.redTextBox.Enabled = false;
            this.redTextBox.Location = new System.Drawing.Point(6, 394);
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(40, 22);
            this.redTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.whoIsInControlLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.disconnecButton);
            this.groupBox2.Controls.Add(this.connectButton);
            this.groupBox2.Controls.Add(this.controlFromPCButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 89);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // whoIsInControlLabel
            // 
            this.whoIsInControlLabel.AutoSize = true;
            this.whoIsInControlLabel.Location = new System.Drawing.Point(454, 39);
            this.whoIsInControlLabel.Name = "whoIsInControlLabel";
            this.whoIsInControlLabel.Size = new System.Drawing.Size(13, 17);
            this.whoIsInControlLabel.TabIndex = 4;
            this.whoIsInControlLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "In Control:";
            // 
            // disconnecButton
            // 
            this.disconnecButton.Location = new System.Drawing.Point(114, 30);
            this.disconnecButton.Name = "disconnecButton";
            this.disconnecButton.Size = new System.Drawing.Size(105, 35);
            this.disconnecButton.TabIndex = 2;
            this.disconnecButton.Text = "Disconnect";
            this.disconnecButton.UseVisualStyleBackColor = true;
            this.disconnecButton.Click += new System.EventHandler(this.disconnecButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(15, 30);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(93, 35);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.arduinoBlueTextBox);
            this.groupBox3.Controls.Add(this.arduinoColorPanel);
            this.groupBox3.Controls.Add(this.arduinoGreenTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.arduinoRedTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(391, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 430);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitor color from the Arduino";
            // 
            // arduinoBlueTextBox
            // 
            this.arduinoBlueTextBox.Enabled = false;
            this.arduinoBlueTextBox.Location = new System.Drawing.Point(140, 66);
            this.arduinoBlueTextBox.Name = "arduinoBlueTextBox";
            this.arduinoBlueTextBox.Size = new System.Drawing.Size(40, 22);
            this.arduinoBlueTextBox.TabIndex = 4;
            this.arduinoBlueTextBox.Text = "0";
            // 
            // arduinoColorPanel
            // 
            this.arduinoColorPanel.BackColor = System.Drawing.Color.Black;
            this.arduinoColorPanel.Location = new System.Drawing.Point(16, 95);
            this.arduinoColorPanel.Name = "arduinoColorPanel";
            this.arduinoColorPanel.Size = new System.Drawing.Size(164, 110);
            this.arduinoColorPanel.TabIndex = 3;
            // 
            // arduinoGreenTextBox
            // 
            this.arduinoGreenTextBox.Enabled = false;
            this.arduinoGreenTextBox.Location = new System.Drawing.Point(78, 66);
            this.arduinoGreenTextBox.Name = "arduinoGreenTextBox";
            this.arduinoGreenTextBox.Size = new System.Drawing.Size(40, 22);
            this.arduinoGreenTextBox.TabIndex = 4;
            this.arduinoGreenTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Green";
            // 
            // arduinoRedTextBox
            // 
            this.arduinoRedTextBox.Enabled = false;
            this.arduinoRedTextBox.Location = new System.Drawing.Point(16, 67);
            this.arduinoRedTextBox.Name = "arduinoRedTextBox";
            this.arduinoRedTextBox.Size = new System.Drawing.Size(40, 22);
            this.arduinoRedTextBox.TabIndex = 4;
            this.arduinoRedTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blue";
            // 
            // RemoteControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.remoteControlGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RemoteControlForm";
            this.Text = "Living Color Remote Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RemoteControlForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).EndInit();
            this.remoteControlGroupBox.ResumeLayout(false);
            this.remoteControlGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar redSlider;
        private System.Windows.Forms.TrackBar greenSlider;
        private System.Windows.Forms.TrackBar blueSlider;
        private System.Windows.Forms.Label redSliderLabel;
        private System.Windows.Forms.Label greenSliderLabel;
        private System.Windows.Forms.Label blueSliderLabel;
        private System.Windows.Forms.Button controlFromPCButton;
        private System.Windows.Forms.Panel pcColorPanel;
        private System.Windows.Forms.GroupBox remoteControlGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel arduinoColorPanel;
        private System.Windows.Forms.Label whoIsInControlLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox blueTextBox;
        private System.Windows.Forms.TextBox greenTextBox;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.TextBox arduinoBlueTextBox;
        private System.Windows.Forms.TextBox arduinoGreenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arduinoRedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button disconnecButton;
    }
}

