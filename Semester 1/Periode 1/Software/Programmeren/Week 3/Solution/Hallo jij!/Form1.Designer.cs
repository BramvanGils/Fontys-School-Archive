﻿namespace Hallo_jij_
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.RadioButtonMan = new System.Windows.Forms.RadioButton();
            this.RadioButtonVrouw = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(13, 13);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 20);
            this.TextBox.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(13, 87);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "Button";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // RadioButtonMan
            // 
            this.RadioButtonMan.AutoSize = true;
            this.RadioButtonMan.Checked = true;
            this.RadioButtonMan.Location = new System.Drawing.Point(13, 40);
            this.RadioButtonMan.Name = "RadioButtonMan";
            this.RadioButtonMan.Size = new System.Drawing.Size(46, 17);
            this.RadioButtonMan.TabIndex = 2;
            this.RadioButtonMan.TabStop = true;
            this.RadioButtonMan.Text = "Man";
            this.RadioButtonMan.UseVisualStyleBackColor = true;
            // 
            // RadioButtonVrouw
            // 
            this.RadioButtonVrouw.AutoSize = true;
            this.RadioButtonVrouw.Location = new System.Drawing.Point(13, 64);
            this.RadioButtonVrouw.Name = "RadioButtonVrouw";
            this.RadioButtonVrouw.Size = new System.Drawing.Size(55, 17);
            this.RadioButtonVrouw.TabIndex = 3;
            this.RadioButtonVrouw.TabStop = true;
            this.RadioButtonVrouw.Text = "Vrouw";
            this.RadioButtonVrouw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 130);
            this.Controls.Add(this.RadioButtonVrouw);
            this.Controls.Add(this.RadioButtonMan);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.RadioButton RadioButtonMan;
        private System.Windows.Forms.RadioButton RadioButtonVrouw;
    }
}

