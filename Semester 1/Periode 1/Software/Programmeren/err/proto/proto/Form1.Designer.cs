namespace proto
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
            this.TextboxString = new System.Windows.Forms.TextBox();
            this.TextboxInt = new System.Windows.Forms.TextBox();
            this.LabelAntwoord = new System.Windows.Forms.Label();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextboxString
            // 
            this.TextboxString.Location = new System.Drawing.Point(12, 12);
            this.TextboxString.Name = "TextboxString";
            this.TextboxString.Size = new System.Drawing.Size(100, 20);
            this.TextboxString.TabIndex = 0;
            // 
            // TextboxInt
            // 
            this.TextboxInt.Location = new System.Drawing.Point(12, 39);
            this.TextboxInt.Name = "TextboxInt";
            this.TextboxInt.Size = new System.Drawing.Size(100, 20);
            this.TextboxInt.TabIndex = 1;
            // 
            // LabelAntwoord
            // 
            this.LabelAntwoord.AutoSize = true;
            this.LabelAntwoord.Location = new System.Drawing.Point(12, 62);
            this.LabelAntwoord.Name = "LabelAntwoord";
            this.LabelAntwoord.Size = new System.Drawing.Size(0, 13);
            this.LabelAntwoord.TabIndex = 2;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(12, 78);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalculate.TabIndex = 3;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 116);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.LabelAntwoord);
            this.Controls.Add(this.TextboxInt);
            this.Controls.Add(this.TextboxString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxString;
        private System.Windows.Forms.TextBox TextboxInt;
        private System.Windows.Forms.Label LabelAntwoord;
        private System.Windows.Forms.Button ButtonCalculate;
    }
}

