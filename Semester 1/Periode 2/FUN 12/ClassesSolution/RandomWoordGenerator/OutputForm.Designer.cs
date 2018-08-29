namespace RandomWoordGenerator
{
    partial class OutputForm
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
            this.LabelOutput = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(13, 13);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(0, 13);
            this.LabelOutput.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(5, 31);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(153, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "Keer Terug";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 66);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.LabelOutput);
            this.Name = "OutputForm";
            this.Text = "WoordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Button Button;
    }
}