namespace ecofootprint_final
{
    partial class history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(history));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buildingBox = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.acBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fanBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vbBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cfBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.disBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fuelBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(191, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 119);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // yearBox
            // 
            this.yearBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearBox.Location = new System.Drawing.Point(81, 288);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(100, 22);
            this.yearBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Year";
            // 
            // monthBox
            // 
            this.monthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBox.Location = new System.Drawing.Point(81, 260);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(100, 22);
            this.monthBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Month";
            // 
            // buildingBox
            // 
            this.buildingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buildingBox.FormattingEnabled = true;
            this.buildingBox.Items.AddRange(new object[] {
            "CICS",
            "ACES",
            "GYM",
            "CEAFA",
            "CIT",
            "Student\'s Center",
            "Steer Hub"});
            this.buildingBox.Location = new System.Drawing.Point(30, 207);
            this.buildingBox.Name = "buildingBox";
            this.buildingBox.Size = new System.Drawing.Size(151, 24);
            this.buildingBox.TabIndex = 9;
            this.buildingBox.Text = "Building";
            // 
            // find
            // 
            this.find.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.find.Location = new System.Drawing.Point(65, 335);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(85, 29);
            this.find.TabIndex = 15;
            this.find.Text = "Search";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back.Location = new System.Drawing.Point(65, 370);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 29);
            this.back.TabIndex = 29;
            this.back.Text = "Return";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Controls.Add(this.fuelBox);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.cfBox);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.timeBox);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.disBox);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.vbBox);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.fanBox);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.lbBox);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.acBox);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.pcBox);
            this.groupBox.Location = new System.Drawing.Point(209, 160);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(536, 261);
            this.groupBox.TabIndex = 30;
            this.groupBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "PC";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Electricity";
            // 
            // pcBox
            // 
            this.pcBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcBox.BackColor = System.Drawing.Color.White;
            this.pcBox.Enabled = false;
            this.pcBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.pcBox.Location = new System.Drawing.Point(155, 79);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(94, 22);
            this.pcBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aircon";
            // 
            // acBox
            // 
            this.acBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acBox.BackColor = System.Drawing.Color.White;
            this.acBox.Enabled = false;
            this.acBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.acBox.Location = new System.Drawing.Point(155, 107);
            this.acBox.Name = "acBox";
            this.acBox.Size = new System.Drawing.Size(94, 22);
            this.acBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fan";
            // 
            // fanBox
            // 
            this.fanBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fanBox.BackColor = System.Drawing.Color.White;
            this.fanBox.Enabled = false;
            this.fanBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.fanBox.Location = new System.Drawing.Point(155, 163);
            this.fanBox.Name = "fanBox";
            this.fanBox.Size = new System.Drawing.Size(94, 22);
            this.fanBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lightbulb";
            // 
            // lbBox
            // 
            this.lbBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBox.BackColor = System.Drawing.Color.White;
            this.lbBox.Enabled = false;
            this.lbBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbBox.Location = new System.Drawing.Point(155, 135);
            this.lbBox.Name = "lbBox";
            this.lbBox.Size = new System.Drawing.Size(94, 22);
            this.lbBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Viewboard";
            // 
            // vbBox
            // 
            this.vbBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vbBox.BackColor = System.Drawing.Color.White;
            this.vbBox.Enabled = false;
            this.vbBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.vbBox.Location = new System.Drawing.Point(155, 191);
            this.vbBox.Name = "vbBox";
            this.vbBox.Size = new System.Drawing.Size(94, 22);
            this.vbBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Carbon Footprint";
            // 
            // cfBox
            // 
            this.cfBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cfBox.BackColor = System.Drawing.Color.White;
            this.cfBox.Enabled = false;
            this.cfBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cfBox.Location = new System.Drawing.Point(393, 191);
            this.cfBox.Name = "cfBox";
            this.cfBox.Size = new System.Drawing.Size(94, 22);
            this.cfBox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Time";
            // 
            // timeBox
            // 
            this.timeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeBox.BackColor = System.Drawing.Color.White;
            this.timeBox.Enabled = false;
            this.timeBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.timeBox.Location = new System.Drawing.Point(393, 132);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(94, 22);
            this.timeBox.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Distance";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Transportation";
            // 
            // disBox
            // 
            this.disBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disBox.BackColor = System.Drawing.Color.White;
            this.disBox.Enabled = false;
            this.disBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.disBox.Location = new System.Drawing.Point(393, 104);
            this.disBox.Name = "disBox";
            this.disBox.Size = new System.Drawing.Size(94, 22);
            this.disBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(310, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Fuel Type";
            // 
            // fuelBox
            // 
            this.fuelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fuelBox.BackColor = System.Drawing.Color.White;
            this.fuelBox.Enabled = false;
            this.fuelBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.fuelBox.Location = new System.Drawing.Point(393, 79);
            this.fuelBox.Name = "fuelBox";
            this.fuelBox.Size = new System.Drawing.Size(94, 22);
            this.fuelBox.TabIndex = 18;
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.find);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buildingBox);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "history";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox buildingBox;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pcBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vbBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fanBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox acBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cfBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox disBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox fuelBox;
    }
}