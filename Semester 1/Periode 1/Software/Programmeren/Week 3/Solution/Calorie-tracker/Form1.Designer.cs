namespace Calorie_tracker
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
            this.GeslachtGroupBox = new System.Windows.Forms.GroupBox();
            this.VrouwRadioButton = new System.Windows.Forms.RadioButton();
            this.ManRadioButton = new System.Windows.Forms.RadioButton();
            this.LevenstijlGroupBox = new System.Windows.Forms.GroupBox();
            this.NietActiefRadioButton = new System.Windows.Forms.RadioButton();
            this.ActiefRadioButton = new System.Windows.Forms.RadioButton();
            this.LeeftijdLabel = new System.Windows.Forms.Label();
            this.LeeftijdTextBox = new System.Windows.Forms.TextBox();
            this.BerekenButton = new System.Windows.Forms.Button();
            this.CalorienLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ZwangerCheckBox = new System.Windows.Forms.CheckBox();
            this.GeslachtGroupBox.SuspendLayout();
            this.LevenstijlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeslachtGroupBox
            // 
            this.GeslachtGroupBox.Controls.Add(this.ZwangerCheckBox);
            this.GeslachtGroupBox.Controls.Add(this.VrouwRadioButton);
            this.GeslachtGroupBox.Controls.Add(this.ManRadioButton);
            this.GeslachtGroupBox.Location = new System.Drawing.Point(12, 12);
            this.GeslachtGroupBox.Name = "GeslachtGroupBox";
            this.GeslachtGroupBox.Size = new System.Drawing.Size(79, 90);
            this.GeslachtGroupBox.TabIndex = 0;
            this.GeslachtGroupBox.TabStop = false;
            this.GeslachtGroupBox.Text = "Geslacht";
            this.GeslachtGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // VrouwRadioButton
            // 
            this.VrouwRadioButton.AutoSize = true;
            this.VrouwRadioButton.Location = new System.Drawing.Point(7, 39);
            this.VrouwRadioButton.Name = "VrouwRadioButton";
            this.VrouwRadioButton.Size = new System.Drawing.Size(55, 17);
            this.VrouwRadioButton.TabIndex = 1;
            this.VrouwRadioButton.Text = "Vrouw";
            this.VrouwRadioButton.UseVisualStyleBackColor = true;
            this.VrouwRadioButton.CheckedChanged += new System.EventHandler(this.VrouwRadioButton_CheckedChanged);
            // 
            // ManRadioButton
            // 
            this.ManRadioButton.AutoSize = true;
            this.ManRadioButton.Checked = true;
            this.ManRadioButton.Location = new System.Drawing.Point(7, 20);
            this.ManRadioButton.Name = "ManRadioButton";
            this.ManRadioButton.Size = new System.Drawing.Size(46, 17);
            this.ManRadioButton.TabIndex = 0;
            this.ManRadioButton.TabStop = true;
            this.ManRadioButton.Text = "Man";
            this.ManRadioButton.UseVisualStyleBackColor = true;
            // 
            // LevenstijlGroupBox
            // 
            this.LevenstijlGroupBox.Controls.Add(this.NietActiefRadioButton);
            this.LevenstijlGroupBox.Controls.Add(this.ActiefRadioButton);
            this.LevenstijlGroupBox.Location = new System.Drawing.Point(108, 12);
            this.LevenstijlGroupBox.Name = "LevenstijlGroupBox";
            this.LevenstijlGroupBox.Size = new System.Drawing.Size(176, 66);
            this.LevenstijlGroupBox.TabIndex = 1;
            this.LevenstijlGroupBox.TabStop = false;
            this.LevenstijlGroupBox.Text = "Levenstijl";
            // 
            // NietActiefRadioButton
            // 
            this.NietActiefRadioButton.AutoSize = true;
            this.NietActiefRadioButton.Location = new System.Drawing.Point(7, 39);
            this.NietActiefRadioButton.Name = "NietActiefRadioButton";
            this.NietActiefRadioButton.Size = new System.Drawing.Size(145, 17);
            this.NietActiefRadioButton.TabIndex = 1;
            this.NietActiefRadioButton.Text = "Niet actief (couch potato)";
            this.NietActiefRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActiefRadioButton
            // 
            this.ActiefRadioButton.AutoSize = true;
            this.ActiefRadioButton.Checked = true;
            this.ActiefRadioButton.Location = new System.Drawing.Point(7, 20);
            this.ActiefRadioButton.Name = "ActiefRadioButton";
            this.ActiefRadioButton.Size = new System.Drawing.Size(98, 17);
            this.ActiefRadioButton.TabIndex = 0;
            this.ActiefRadioButton.TabStop = true;
            this.ActiefRadioButton.Text = "Actief (normaal)";
            this.ActiefRadioButton.UseVisualStyleBackColor = true;
            // 
            // LeeftijdLabel
            // 
            this.LeeftijdLabel.AutoSize = true;
            this.LeeftijdLabel.Location = new System.Drawing.Point(291, 21);
            this.LeeftijdLabel.Name = "LeeftijdLabel";
            this.LeeftijdLabel.Size = new System.Drawing.Size(81, 13);
            this.LeeftijdLabel.TabIndex = 2;
            this.LeeftijdLabel.Text = "Leeftijd in jaren:";
            // 
            // LeeftijdTextBox
            // 
            this.LeeftijdTextBox.Location = new System.Drawing.Point(293, 38);
            this.LeeftijdTextBox.Name = "LeeftijdTextBox";
            this.LeeftijdTextBox.Size = new System.Drawing.Size(96, 20);
            this.LeeftijdTextBox.TabIndex = 3;
            this.LeeftijdTextBox.TextChanged += new System.EventHandler(this.LeeftijdTextBox_TextChanged);
            // 
            // BerekenButton
            // 
            this.BerekenButton.Location = new System.Drawing.Point(169, 81);
            this.BerekenButton.Name = "BerekenButton";
            this.BerekenButton.Size = new System.Drawing.Size(75, 23);
            this.BerekenButton.TabIndex = 4;
            this.BerekenButton.Text = "Bereken";
            this.BerekenButton.UseVisualStyleBackColor = true;
            this.BerekenButton.Click += new System.EventHandler(this.BerekenButton_Click);
            // 
            // CalorienLabel
            // 
            this.CalorienLabel.AutoSize = true;
            this.CalorienLabel.Location = new System.Drawing.Point(249, 89);
            this.CalorienLabel.Name = "CalorienLabel";
            this.CalorienLabel.Size = new System.Drawing.Size(57, 13);
            this.CalorienLabel.TabIndex = 5;
            this.CalorienLabel.Text = "<Calorien>";
            this.CalorienLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(294, 61);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(65, 13);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "voer getal in";
            this.ErrorLabel.Visible = false;
            // 
            // ZwangerCheckBox
            // 
            this.ZwangerCheckBox.AutoSize = true;
            this.ZwangerCheckBox.Enabled = false;
            this.ZwangerCheckBox.Location = new System.Drawing.Point(7, 58);
            this.ZwangerCheckBox.Name = "ZwangerCheckBox";
            this.ZwangerCheckBox.Size = new System.Drawing.Size(68, 17);
            this.ZwangerCheckBox.TabIndex = 2;
            this.ZwangerCheckBox.Text = "Zwanger";
            this.ZwangerCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 162);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CalorienLabel);
            this.Controls.Add(this.BerekenButton);
            this.Controls.Add(this.LeeftijdTextBox);
            this.Controls.Add(this.LeeftijdLabel);
            this.Controls.Add(this.LevenstijlGroupBox);
            this.Controls.Add(this.GeslachtGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GeslachtGroupBox.ResumeLayout(false);
            this.GeslachtGroupBox.PerformLayout();
            this.LevenstijlGroupBox.ResumeLayout(false);
            this.LevenstijlGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GeslachtGroupBox;
        private System.Windows.Forms.GroupBox LevenstijlGroupBox;
        private System.Windows.Forms.Label LeeftijdLabel;
        private System.Windows.Forms.TextBox LeeftijdTextBox;
        private System.Windows.Forms.Button BerekenButton;
        private System.Windows.Forms.RadioButton VrouwRadioButton;
        private System.Windows.Forms.RadioButton ManRadioButton;
        private System.Windows.Forms.RadioButton NietActiefRadioButton;
        private System.Windows.Forms.RadioButton ActiefRadioButton;
        private System.Windows.Forms.Label CalorienLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.CheckBox ZwangerCheckBox;
    }
}

