namespace Euro_dollar_converter
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
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.koersboxdollar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.toAbutton = new System.Windows.Forms.Button();
            this.Abox = new System.Windows.Forms.TextBox();
            this.toBbutton = new System.Windows.Forms.Button();
            this.Bbox = new System.Windows.Forms.TextBox();
            this.errorlabel = new System.Windows.Forms.Label();
            this.comboBoxB = new System.Windows.Forms.ComboBox();
            this.koersboxyen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.koersboxdollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koersboxyen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(439, 46);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(98, 108);
            this.labelB.TabIndex = 0;
            this.labelB.Text = "$";
            this.labelB.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(1, 46);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(98, 108);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "€";
            // 
            // koersboxdollar
            // 
            this.koersboxdollar.DecimalPlaces = 2;
            this.koersboxdollar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.koersboxdollar.Location = new System.Drawing.Point(287, 134);
            this.koersboxdollar.Name = "koersboxdollar";
            this.koersboxdollar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.koersboxdollar.Size = new System.Drawing.Size(68, 20);
            this.koersboxdollar.TabIndex = 2;
            this.koersboxdollar.Value = new decimal(new int[] {
            123013,
            0,
            0,
            327680});
            this.koersboxdollar.ValueChanged += new System.EventHandler(this.koersbox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Koers: 1 euro = $";
            // 
            // toAbutton
            // 
            this.toAbutton.Location = new System.Drawing.Point(211, 91);
            this.toAbutton.Name = "toAbutton";
            this.toAbutton.Size = new System.Drawing.Size(55, 23);
            this.toAbutton.TabIndex = 4;
            this.toAbutton.Text = "<";
            this.toAbutton.UseVisualStyleBackColor = true;
            this.toAbutton.Click += new System.EventHandler(this.toAbutton_Click);
            // 
            // Abox
            // 
            this.Abox.Location = new System.Drawing.Point(105, 93);
            this.Abox.Name = "Abox";
            this.Abox.Size = new System.Drawing.Size(100, 20);
            this.Abox.TabIndex = 5;
            this.Abox.Text = "1";
            this.Abox.TextChanged += new System.EventHandler(this.Abox_TextChanged);
            // 
            // toBbutton
            // 
            this.toBbutton.Location = new System.Drawing.Point(272, 91);
            this.toBbutton.Name = "toBbutton";
            this.toBbutton.Size = new System.Drawing.Size(55, 23);
            this.toBbutton.TabIndex = 6;
            this.toBbutton.Text = ">";
            this.toBbutton.UseVisualStyleBackColor = true;
            this.toBbutton.Click += new System.EventHandler(this.toBbutton_Click);
            // 
            // Bbox
            // 
            this.Bbox.Location = new System.Drawing.Point(333, 93);
            this.Bbox.Name = "Bbox";
            this.Bbox.Size = new System.Drawing.Size(100, 20);
            this.Bbox.TabIndex = 7;
            this.Bbox.Text = "1";
            this.Bbox.TextChanged += new System.EventHandler(this.Bbox_TextChanged);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(202, 64);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(125, 13);
            this.errorlabel.TabIndex = 8;
            this.errorlabel.Text = "Error: insert numbers only";
            this.errorlabel.Visible = false;
            this.errorlabel.Click += new System.EventHandler(this.errorlabel_Click);
            // 
            // comboBoxB
            // 
            this.comboBoxB.FormattingEnabled = true;
            this.comboBoxB.Items.AddRange(new object[] {
            "Dollars",
            "Yen"});
            this.comboBoxB.Location = new System.Drawing.Point(443, 157);
            this.comboBoxB.Name = "comboBoxB";
            this.comboBoxB.Size = new System.Drawing.Size(78, 21);
            this.comboBoxB.TabIndex = 10;
            this.comboBoxB.Text = "Dollars";
            this.comboBoxB.SelectedIndexChanged += new System.EventHandler(this.comboBoxB_SelectedIndexChanged);
            this.comboBoxB.TextUpdate += new System.EventHandler(this.comboBoxB_TextUpdate);
            // 
            // koersboxyen
            // 
            this.koersboxyen.DecimalPlaces = 2;
            this.koersboxyen.Location = new System.Drawing.Point(287, 157);
            this.koersboxyen.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.koersboxyen.Name = "koersboxyen";
            this.koersboxyen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.koersboxyen.Size = new System.Drawing.Size(68, 20);
            this.koersboxyen.TabIndex = 11;
            this.koersboxyen.Value = new decimal(new int[] {
            131,
            0,
            0,
            0});
            this.koersboxyen.ValueChanged += new System.EventHandler(this.koersboxyen_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Koers: 1 euro = ¥";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.koersboxyen);
            this.Controls.Add(this.comboBoxB);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.Bbox);
            this.Controls.Add(this.toBbutton);
            this.Controls.Add(this.Abox);
            this.Controls.Add(this.toAbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.koersboxdollar);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.koersboxdollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koersboxyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.NumericUpDown koersboxdollar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toAbutton;
        private System.Windows.Forms.TextBox Abox;
        private System.Windows.Forms.Button toBbutton;
        private System.Windows.Forms.TextBox Bbox;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.ComboBox comboBoxB;
        private System.Windows.Forms.NumericUpDown koersboxyen;
        private System.Windows.Forms.Label label1;
    }
}

