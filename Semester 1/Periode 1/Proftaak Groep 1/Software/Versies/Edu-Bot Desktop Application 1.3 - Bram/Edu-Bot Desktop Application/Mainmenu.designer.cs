﻿namespace Edu_Bot_Desktop_Application
{
    partial class Mainmenu
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
            this.labelTitel = new System.Windows.Forms.Label();
            this.buttonSpelenMainmenu = new System.Windows.Forms.Button();
            this.buttonRobotinstellingenMainmenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSluitenMainmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Felix Titling", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.ForeColor = System.Drawing.Color.White;
            this.labelTitel.Location = new System.Drawing.Point(239, 7);
            this.labelTitel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(138, 35);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "Edubot";
            // 
            // buttonSpelenMainmenu
            // 
            this.buttonSpelenMainmenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSpelenMainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpelenMainmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSpelenMainmenu.Location = new System.Drawing.Point(96, 80);
            this.buttonSpelenMainmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSpelenMainmenu.Name = "buttonSpelenMainmenu";
            this.buttonSpelenMainmenu.Size = new System.Drawing.Size(412, 65);
            this.buttonSpelenMainmenu.TabIndex = 1;
            this.buttonSpelenMainmenu.Text = "Spelen";
            this.buttonSpelenMainmenu.UseVisualStyleBackColor = false;
            this.buttonSpelenMainmenu.Click += new System.EventHandler(this.buttonSpelenMainmenu_Click);
            // 
            // buttonRobotinstellingenMainmenu
            // 
            this.buttonRobotinstellingenMainmenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRobotinstellingenMainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRobotinstellingenMainmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRobotinstellingenMainmenu.Location = new System.Drawing.Point(96, 159);
            this.buttonRobotinstellingenMainmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRobotinstellingenMainmenu.Name = "buttonRobotinstellingenMainmenu";
            this.buttonRobotinstellingenMainmenu.Size = new System.Drawing.Size(412, 65);
            this.buttonRobotinstellingenMainmenu.TabIndex = 2;
            this.buttonRobotinstellingenMainmenu.Text = "Robot instellingen";
            this.buttonRobotinstellingenMainmenu.UseVisualStyleBackColor = false;
            this.buttonRobotinstellingenMainmenu.Click += new System.EventHandler(this.buttonRobotinstellingenMainmenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(96, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Instellingen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSluitenMainmenu
            // 
            this.buttonSluitenMainmenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSluitenMainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSluitenMainmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSluitenMainmenu.Location = new System.Drawing.Point(323, 246);
            this.buttonSluitenMainmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSluitenMainmenu.Name = "buttonSluitenMainmenu";
            this.buttonSluitenMainmenu.Size = new System.Drawing.Size(184, 65);
            this.buttonSluitenMainmenu.TabIndex = 4;
            this.buttonSluitenMainmenu.Text = "Sluiten";
            this.buttonSluitenMainmenu.UseVisualStyleBackColor = false;
            this.buttonSluitenMainmenu.Click += new System.EventHandler(this.buttonSluitenMainmenu_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(607, 366);
            this.Controls.Add(this.buttonSluitenMainmenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRobotinstellingenMainmenu);
            this.Controls.Add(this.buttonSpelenMainmenu);
            this.Controls.Add(this.labelTitel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Button buttonSpelenMainmenu;
        private System.Windows.Forms.Button buttonRobotinstellingenMainmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSluitenMainmenu;
    }
}

