namespace Killer_App.Forms
{
    partial class PoolMatch
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
            this.components = new System.ComponentModel.Container();
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DebugLabel1 = new System.Windows.Forms.Label();
            this.DebugLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FrameTimer
            // 
            this.FrameTimer.Interval = 25;
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 12);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update Frame";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DebugLabel1
            // 
            this.DebugLabel1.AutoSize = true;
            this.DebugLabel1.Location = new System.Drawing.Point(804, 12);
            this.DebugLabel1.Name = "DebugLabel1";
            this.DebugLabel1.Size = new System.Drawing.Size(35, 13);
            this.DebugLabel1.TabIndex = 1;
            this.DebugLabel1.Text = "label1";
            // 
            // DebugLabel2
            // 
            this.DebugLabel2.AutoSize = true;
            this.DebugLabel2.Location = new System.Drawing.Point(804, 34);
            this.DebugLabel2.Name = "DebugLabel2";
            this.DebugLabel2.Size = new System.Drawing.Size(35, 13);
            this.DebugLabel2.TabIndex = 2;
            this.DebugLabel2.Text = "label2";
            // 
            // PoolMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(920, 442);
            this.Controls.Add(this.DebugLabel2);
            this.Controls.Add(this.DebugLabel1);
            this.Controls.Add(this.UpdateButton);
            this.Name = "PoolMatch";
            this.Text = "PoolMatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label DebugLabel1;
        private System.Windows.Forms.Label DebugLabel2;
    }
}