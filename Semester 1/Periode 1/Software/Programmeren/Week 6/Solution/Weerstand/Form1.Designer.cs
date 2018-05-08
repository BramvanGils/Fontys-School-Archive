namespace Weerstand
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
            this.TextboxVolt = new System.Windows.Forms.TextBox();
            this.TextboxAmpère = new System.Windows.Forms.TextBox();
            this.LabelVolt = new System.Windows.Forms.Label();
            this.LabelAmpère = new System.Windows.Forms.Label();
            this.LabelWeerstand = new System.Windows.Forms.Label();
            this.ButtonBerekenWeerstand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextboxVolt
            // 
            this.TextboxVolt.Location = new System.Drawing.Point(118, 28);
            this.TextboxVolt.Name = "TextboxVolt";
            this.TextboxVolt.Size = new System.Drawing.Size(100, 20);
            this.TextboxVolt.TabIndex = 0;
            // 
            // TextboxAmpère
            // 
            this.TextboxAmpère.Location = new System.Drawing.Point(12, 28);
            this.TextboxAmpère.Name = "TextboxAmpère";
            this.TextboxAmpère.Size = new System.Drawing.Size(100, 20);
            this.TextboxAmpère.TabIndex = 1;
            // 
            // LabelVolt
            // 
            this.LabelVolt.AutoSize = true;
            this.LabelVolt.Location = new System.Drawing.Point(115, 9);
            this.LabelVolt.Name = "LabelVolt";
            this.LabelVolt.Size = new System.Drawing.Size(25, 13);
            this.LabelVolt.TabIndex = 2;
            this.LabelVolt.Text = "Volt";
            // 
            // LabelAmpère
            // 
            this.LabelAmpère.AutoSize = true;
            this.LabelAmpère.Location = new System.Drawing.Point(12, 9);
            this.LabelAmpère.Name = "LabelAmpère";
            this.LabelAmpère.Size = new System.Drawing.Size(43, 13);
            this.LabelAmpère.TabIndex = 3;
            this.LabelAmpère.Text = "Ampère";
            // 
            // LabelWeerstand
            // 
            this.LabelWeerstand.AutoSize = true;
            this.LabelWeerstand.Location = new System.Drawing.Point(12, 80);
            this.LabelWeerstand.Name = "LabelWeerstand";
            this.LabelWeerstand.Size = new System.Drawing.Size(0, 13);
            this.LabelWeerstand.TabIndex = 4;
            // 
            // ButtonBerekenWeerstand
            // 
            this.ButtonBerekenWeerstand.Location = new System.Drawing.Point(12, 54);
            this.ButtonBerekenWeerstand.Name = "ButtonBerekenWeerstand";
            this.ButtonBerekenWeerstand.Size = new System.Drawing.Size(116, 23);
            this.ButtonBerekenWeerstand.TabIndex = 5;
            this.ButtonBerekenWeerstand.Text = "Bereken Weerstand";
            this.ButtonBerekenWeerstand.UseVisualStyleBackColor = true;
            this.ButtonBerekenWeerstand.Click += new System.EventHandler(this.ButtonBerekenWeerstand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 114);
            this.Controls.Add(this.ButtonBerekenWeerstand);
            this.Controls.Add(this.LabelWeerstand);
            this.Controls.Add(this.LabelAmpère);
            this.Controls.Add(this.LabelVolt);
            this.Controls.Add(this.TextboxAmpère);
            this.Controls.Add(this.TextboxVolt);
            this.Name = "Form1";
            this.Text = "Weerstand Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxVolt;
        private System.Windows.Forms.TextBox TextboxAmpère;
        private System.Windows.Forms.Label LabelVolt;
        private System.Windows.Forms.Label LabelAmpère;
        private System.Windows.Forms.Label LabelWeerstand;
        private System.Windows.Forms.Button ButtonBerekenWeerstand;
    }
}

