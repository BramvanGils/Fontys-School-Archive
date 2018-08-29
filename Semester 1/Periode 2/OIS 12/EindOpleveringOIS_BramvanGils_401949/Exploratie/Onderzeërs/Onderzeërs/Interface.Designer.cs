namespace Onderzeërs
{
    partial class Interface
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
            this.MarineGroupbox = new System.Windows.Forms.GroupBox();
            this.OnderzeërGroupbox = new System.Windows.Forms.GroupBox();
            this.KoelkastGroupbox = new System.Windows.Forms.GroupBox();
            this.PersoneelGroupbox = new System.Windows.Forms.GroupBox();
            this.ElektromotorGroupbox = new System.Windows.Forms.GroupBox();
            this.BenzinemotorGroupbox = new System.Windows.Forms.GroupBox();
            this.OnderzeërListbox = new System.Windows.Forms.ListBox();
            this.KoelkastListbox = new System.Windows.Forms.ListBox();
            this.PersoneelListbox = new System.Windows.Forms.ListBox();
            this.ElektromotorListbox = new System.Windows.Forms.ListBox();
            this.BenzineMotor = new System.Windows.Forms.ListBox();
            this.MarineGroupbox.SuspendLayout();
            this.OnderzeërGroupbox.SuspendLayout();
            this.KoelkastGroupbox.SuspendLayout();
            this.PersoneelGroupbox.SuspendLayout();
            this.ElektromotorGroupbox.SuspendLayout();
            this.BenzinemotorGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MarineGroupbox
            // 
            this.MarineGroupbox.Controls.Add(this.BenzinemotorGroupbox);
            this.MarineGroupbox.Controls.Add(this.ElektromotorGroupbox);
            this.MarineGroupbox.Controls.Add(this.PersoneelGroupbox);
            this.MarineGroupbox.Controls.Add(this.KoelkastGroupbox);
            this.MarineGroupbox.Controls.Add(this.OnderzeërGroupbox);
            this.MarineGroupbox.Location = new System.Drawing.Point(13, 13);
            this.MarineGroupbox.Name = "MarineGroupbox";
            this.MarineGroupbox.Size = new System.Drawing.Size(630, 425);
            this.MarineGroupbox.TabIndex = 0;
            this.MarineGroupbox.TabStop = false;
            this.MarineGroupbox.Text = "Nederlandse Marine";
            // 
            // OnderzeërGroupbox
            // 
            this.OnderzeërGroupbox.Controls.Add(this.OnderzeërListbox);
            this.OnderzeërGroupbox.Location = new System.Drawing.Point(7, 20);
            this.OnderzeërGroupbox.Name = "OnderzeërGroupbox";
            this.OnderzeërGroupbox.Size = new System.Drawing.Size(200, 218);
            this.OnderzeërGroupbox.TabIndex = 0;
            this.OnderzeërGroupbox.TabStop = false;
            this.OnderzeërGroupbox.Text = "Onderzeër";
            // 
            // KoelkastGroupbox
            // 
            this.KoelkastGroupbox.Controls.Add(this.KoelkastListbox);
            this.KoelkastGroupbox.Location = new System.Drawing.Point(7, 245);
            this.KoelkastGroupbox.Name = "KoelkastGroupbox";
            this.KoelkastGroupbox.Size = new System.Drawing.Size(200, 174);
            this.KoelkastGroupbox.TabIndex = 1;
            this.KoelkastGroupbox.TabStop = false;
            this.KoelkastGroupbox.Text = "Koelkast";
            // 
            // PersoneelGroupbox
            // 
            this.PersoneelGroupbox.Controls.Add(this.PersoneelListbox);
            this.PersoneelGroupbox.Location = new System.Drawing.Point(213, 20);
            this.PersoneelGroupbox.Name = "PersoneelGroupbox";
            this.PersoneelGroupbox.Size = new System.Drawing.Size(200, 399);
            this.PersoneelGroupbox.TabIndex = 2;
            this.PersoneelGroupbox.TabStop = false;
            this.PersoneelGroupbox.Text = "Personeel";
            // 
            // ElektromotorGroupbox
            // 
            this.ElektromotorGroupbox.Controls.Add(this.ElektromotorListbox);
            this.ElektromotorGroupbox.Location = new System.Drawing.Point(420, 20);
            this.ElektromotorGroupbox.Name = "ElektromotorGroupbox";
            this.ElektromotorGroupbox.Size = new System.Drawing.Size(200, 198);
            this.ElektromotorGroupbox.TabIndex = 3;
            this.ElektromotorGroupbox.TabStop = false;
            this.ElektromotorGroupbox.Text = "Elektromotor";
            // 
            // BenzinemotorGroupbox
            // 
            this.BenzinemotorGroupbox.Controls.Add(this.BenzineMotor);
            this.BenzinemotorGroupbox.Location = new System.Drawing.Point(420, 224);
            this.BenzinemotorGroupbox.Name = "BenzinemotorGroupbox";
            this.BenzinemotorGroupbox.Size = new System.Drawing.Size(200, 195);
            this.BenzinemotorGroupbox.TabIndex = 4;
            this.BenzinemotorGroupbox.TabStop = false;
            this.BenzinemotorGroupbox.Text = "Benzinemotor";
            // 
            // OnderzeërListbox
            // 
            this.OnderzeërListbox.FormattingEnabled = true;
            this.OnderzeërListbox.Location = new System.Drawing.Point(7, 20);
            this.OnderzeërListbox.Name = "OnderzeërListbox";
            this.OnderzeërListbox.Size = new System.Drawing.Size(187, 186);
            this.OnderzeërListbox.TabIndex = 0;
            this.OnderzeërListbox.SelectedIndexChanged += new System.EventHandler(this.OnderzeërListbox_SelectedIndexChanged);
            // 
            // KoelkastListbox
            // 
            this.KoelkastListbox.FormattingEnabled = true;
            this.KoelkastListbox.Location = new System.Drawing.Point(7, 16);
            this.KoelkastListbox.Name = "KoelkastListbox";
            this.KoelkastListbox.Size = new System.Drawing.Size(187, 147);
            this.KoelkastListbox.TabIndex = 0;
            // 
            // PersoneelListbox
            // 
            this.PersoneelListbox.FormattingEnabled = true;
            this.PersoneelListbox.Location = new System.Drawing.Point(7, 20);
            this.PersoneelListbox.Name = "PersoneelListbox";
            this.PersoneelListbox.Size = new System.Drawing.Size(187, 368);
            this.PersoneelListbox.TabIndex = 0;
            // 
            // ElektromotorListbox
            // 
            this.ElektromotorListbox.FormattingEnabled = true;
            this.ElektromotorListbox.Location = new System.Drawing.Point(7, 20);
            this.ElektromotorListbox.Name = "ElektromotorListbox";
            this.ElektromotorListbox.Size = new System.Drawing.Size(187, 173);
            this.ElektromotorListbox.TabIndex = 0;
            // 
            // BenzineMotor
            // 
            this.BenzineMotor.FormattingEnabled = true;
            this.BenzineMotor.Location = new System.Drawing.Point(7, 20);
            this.BenzineMotor.Name = "BenzineMotor";
            this.BenzineMotor.Size = new System.Drawing.Size(187, 160);
            this.BenzineMotor.TabIndex = 0;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.MarineGroupbox);
            this.Name = "Interface";
            this.Text = "Interface";
            this.MarineGroupbox.ResumeLayout(false);
            this.OnderzeërGroupbox.ResumeLayout(false);
            this.KoelkastGroupbox.ResumeLayout(false);
            this.PersoneelGroupbox.ResumeLayout(false);
            this.ElektromotorGroupbox.ResumeLayout(false);
            this.BenzinemotorGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MarineGroupbox;
        private System.Windows.Forms.GroupBox BenzinemotorGroupbox;
        private System.Windows.Forms.ListBox BenzineMotor;
        private System.Windows.Forms.GroupBox ElektromotorGroupbox;
        private System.Windows.Forms.ListBox ElektromotorListbox;
        private System.Windows.Forms.GroupBox PersoneelGroupbox;
        private System.Windows.Forms.ListBox PersoneelListbox;
        private System.Windows.Forms.GroupBox KoelkastGroupbox;
        private System.Windows.Forms.ListBox KoelkastListbox;
        private System.Windows.Forms.GroupBox OnderzeërGroupbox;
        private System.Windows.Forms.ListBox OnderzeërListbox;
    }
}

