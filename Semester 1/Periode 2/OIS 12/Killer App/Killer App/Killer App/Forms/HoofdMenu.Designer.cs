namespace Killer_App
{
    partial class HoofdMenu
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
            this.button5 = new System.Windows.Forms.Button();
            this.GeschiedenisButton = new System.Windows.Forms.Button();
            this.AfsluitenButton = new System.Windows.Forms.Button();
            this.VerenigingButton = new System.Windows.Forms.Button();
            this.MatchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Mijn Profiel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // GeschiedenisButton
            // 
            this.GeschiedenisButton.Location = new System.Drawing.Point(327, 415);
            this.GeschiedenisButton.Name = "GeschiedenisButton";
            this.GeschiedenisButton.Size = new System.Drawing.Size(117, 23);
            this.GeschiedenisButton.TabIndex = 8;
            this.GeschiedenisButton.Text = "Speel Geschiedenis";
            this.GeschiedenisButton.UseVisualStyleBackColor = true;
            // 
            // AfsluitenButton
            // 
            this.AfsluitenButton.Location = new System.Drawing.Point(698, 415);
            this.AfsluitenButton.Name = "AfsluitenButton";
            this.AfsluitenButton.Size = new System.Drawing.Size(75, 23);
            this.AfsluitenButton.TabIndex = 7;
            this.AfsluitenButton.Text = "Afsluiten";
            this.AfsluitenButton.UseVisualStyleBackColor = true;
            // 
            // VerenigingButton
            // 
            this.VerenigingButton.Location = new System.Drawing.Point(326, 347);
            this.VerenigingButton.Name = "VerenigingButton";
            this.VerenigingButton.Size = new System.Drawing.Size(118, 23);
            this.VerenigingButton.TabIndex = 6;
            this.VerenigingButton.Text = "<Vereniging Naam>";
            this.VerenigingButton.UseVisualStyleBackColor = true;
            this.VerenigingButton.Visible = false;
            // 
            // MatchButton
            // 
            this.MatchButton.Location = new System.Drawing.Point(347, 115);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(75, 23);
            this.MatchButton.TabIndex = 5;
            this.MatchButton.Text = "Zoek Match";
            this.MatchButton.UseVisualStyleBackColor = true;
            // 
            // HoofdMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.GeschiedenisButton);
            this.Controls.Add(this.AfsluitenButton);
            this.Controls.Add(this.VerenigingButton);
            this.Controls.Add(this.MatchButton);
            this.Name = "HoofdMenu";
            this.Text = "Hoofd Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button GeschiedenisButton;
        private System.Windows.Forms.Button AfsluitenButton;
        private System.Windows.Forms.Button VerenigingButton;
        private System.Windows.Forms.Button MatchButton;
    }
}

