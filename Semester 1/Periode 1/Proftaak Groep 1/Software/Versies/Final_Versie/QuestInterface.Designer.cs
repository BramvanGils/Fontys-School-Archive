namespace Final_Versie
{
    partial class QuestInterface
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
            this.ButtonPause = new System.Windows.Forms.Button();
            this.ButtonStatistieken = new System.Windows.Forms.Button();
            this.ButtonInventaris = new System.Windows.Forms.Button();
            this.ButtonQuestLog = new System.Windows.Forms.Button();
            this.TextInterfaceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.Option1Button = new System.Windows.Forms.Button();
            this.Option2Button = new System.Windows.Forms.Button();
            this.Option3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonPause
            // 
            this.ButtonPause.Location = new System.Drawing.Point(93, 12);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(75, 23);
            this.ButtonPause.TabIndex = 1;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.UseVisualStyleBackColor = true;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ButtonStatistieken
            // 
            this.ButtonStatistieken.Location = new System.Drawing.Point(174, 12);
            this.ButtonStatistieken.Name = "ButtonStatistieken";
            this.ButtonStatistieken.Size = new System.Drawing.Size(75, 23);
            this.ButtonStatistieken.TabIndex = 2;
            this.ButtonStatistieken.Text = "Statistieken";
            this.ButtonStatistieken.UseVisualStyleBackColor = true;
            this.ButtonStatistieken.Click += new System.EventHandler(this.ButtonStatistieken_Click);
            // 
            // ButtonInventaris
            // 
            this.ButtonInventaris.Location = new System.Drawing.Point(336, 12);
            this.ButtonInventaris.Name = "ButtonInventaris";
            this.ButtonInventaris.Size = new System.Drawing.Size(75, 23);
            this.ButtonInventaris.TabIndex = 4;
            this.ButtonInventaris.Text = "Inventaris";
            this.ButtonInventaris.UseVisualStyleBackColor = true;
            this.ButtonInventaris.Click += new System.EventHandler(this.ButtonInventaris_Click);
            // 
            // ButtonQuestLog
            // 
            this.ButtonQuestLog.Location = new System.Drawing.Point(255, 12);
            this.ButtonQuestLog.Name = "ButtonQuestLog";
            this.ButtonQuestLog.Size = new System.Drawing.Size(75, 23);
            this.ButtonQuestLog.TabIndex = 3;
            this.ButtonQuestLog.Text = "QuestLog";
            this.ButtonQuestLog.UseVisualStyleBackColor = true;
            this.ButtonQuestLog.Click += new System.EventHandler(this.ButtonQuestLog_Click);
            // 
            // TextInterfaceRichTextBox
            // 
            this.TextInterfaceRichTextBox.Location = new System.Drawing.Point(93, 42);
            this.TextInterfaceRichTextBox.Name = "TextInterfaceRichTextBox";
            this.TextInterfaceRichTextBox.Size = new System.Drawing.Size(264, 96);
            this.TextInterfaceRichTextBox.TabIndex = 5;
            this.TextInterfaceRichTextBox.Text = "";
            // 
            // Option1Button
            // 
            this.Option1Button.Location = new System.Drawing.Point(93, 145);
            this.Option1Button.Name = "Option1Button";
            this.Option1Button.Size = new System.Drawing.Size(75, 23);
            this.Option1Button.TabIndex = 6;
            this.Option1Button.Text = "button1";
            this.Option1Button.UseVisualStyleBackColor = true;
            // 
            // Option2Button
            // 
            this.Option2Button.Location = new System.Drawing.Point(175, 145);
            this.Option2Button.Name = "Option2Button";
            this.Option2Button.Size = new System.Drawing.Size(75, 23);
            this.Option2Button.TabIndex = 7;
            this.Option2Button.Text = "button2";
            this.Option2Button.UseVisualStyleBackColor = true;
            // 
            // Option3Button
            // 
            this.Option3Button.Location = new System.Drawing.Point(255, 145);
            this.Option3Button.Name = "Option3Button";
            this.Option3Button.Size = new System.Drawing.Size(75, 23);
            this.Option3Button.TabIndex = 8;
            this.Option3Button.Text = "button3";
            this.Option3Button.UseVisualStyleBackColor = true;
            // 
            // QuestInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 530);
            this.Controls.Add(this.Option3Button);
            this.Controls.Add(this.Option2Button);
            this.Controls.Add(this.Option1Button);
            this.Controls.Add(this.TextInterfaceRichTextBox);
            this.Controls.Add(this.ButtonInventaris);
            this.Controls.Add(this.ButtonQuestLog);
            this.Controls.Add(this.ButtonStatistieken);
            this.Controls.Add(this.ButtonPause);
            this.Name = "QuestInterface";
            this.Text = "QuestInterface";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonPause;
        private System.Windows.Forms.Button ButtonStatistieken;
        private System.Windows.Forms.Button ButtonInventaris;
        private System.Windows.Forms.Button ButtonQuestLog;
        private System.Windows.Forms.RichTextBox TextInterfaceRichTextBox;
        private System.Windows.Forms.Button Option1Button;
        private System.Windows.Forms.Button Option2Button;
        private System.Windows.Forms.Button Option3Button;
    }
}