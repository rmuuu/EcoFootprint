namespace EcoFootprint
{
    partial class Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Input));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.month = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.pop = new System.Windows.Forms.Label();
            this.gasoline = new System.Windows.Forms.Label();
            this.elec = new System.Windows.Forms.Label();
            this.foodWaste = new System.Windows.Forms.Label();
            this.recycled = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.population = new System.Windows.Forms.TextBox();
            this.bill = new System.Windows.Forms.TextBox();
            this.gas = new System.Windows.Forms.TextBox();
            this.waste = new System.Windows.Forms.TextBox();
            this.recycle = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.monthBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 138);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(100, 172);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(49, 16);
            this.month.TabIndex = 3;
            this.month.Text = "Month :";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(499, 172);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(91, 16);
            this.size.TabIndex = 5;
            this.size.Text = "Location size :";
            // 
            // pop
            // 
            this.pop.AutoSize = true;
            this.pop.Location = new System.Drawing.Point(513, 203);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(77, 16);
            this.pop.TabIndex = 6;
            this.pop.Text = "Population :";
            // 
            // gasoline
            // 
            this.gasoline.AutoSize = true;
            this.gasoline.Location = new System.Drawing.Point(408, 267);
            this.gasoline.Name = "gasoline";
            this.gasoline.Size = new System.Drawing.Size(182, 16);
            this.gasoline.TabIndex = 7;
            this.gasoline.Text = "Total Gasoline Consumption :";
            // 
            // elec
            // 
            this.elec.AutoSize = true;
            this.elec.Location = new System.Drawing.Point(452, 237);
            this.elec.Name = "elec";
            this.elec.Size = new System.Drawing.Size(138, 16);
            this.elec.TabIndex = 8;
            this.elec.Text = "Electric Consumption :";
            // 
            // foodWaste
            // 
            this.foodWaste.AutoSize = true;
            this.foodWaste.Location = new System.Drawing.Point(450, 295);
            this.foodWaste.Name = "foodWaste";
            this.foodWaste.Size = new System.Drawing.Size(140, 16);
            this.foodWaste.TabIndex = 9;
            this.foodWaste.Text = "Waste Disposed (kg) :";
            // 
            // recycled
            // 
            this.recycled.AutoSize = true;
            this.recycled.Location = new System.Drawing.Point(435, 324);
            this.recycled.Name = "recycled";
            this.recycled.Size = new System.Drawing.Size(155, 16);
            this.recycled.TabIndex = 10;
            this.recycled.Text = "Materials Recycled (kg) :";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(107, 203);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(42, 16);
            this.year.TabIndex = 11;
            this.year.Text = "Year :";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(173, 200);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(100, 22);
            this.yearBox.TabIndex = 12;
            // 
            // sizeBox
            // 
            this.sizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeBox.Location = new System.Drawing.Point(613, 169);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(100, 22);
            this.sizeBox.TabIndex = 13;
            // 
            // population
            // 
            this.population.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.population.Location = new System.Drawing.Point(613, 200);
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(100, 22);
            this.population.TabIndex = 14;
            // 
            // bill
            // 
            this.bill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bill.Location = new System.Drawing.Point(613, 234);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(100, 22);
            this.bill.TabIndex = 15;
            // 
            // gas
            // 
            this.gas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gas.Location = new System.Drawing.Point(613, 264);
            this.gas.Name = "gas";
            this.gas.Size = new System.Drawing.Size(100, 22);
            this.gas.TabIndex = 16;
            // 
            // waste
            // 
            this.waste.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.waste.Location = new System.Drawing.Point(613, 292);
            this.waste.Name = "waste";
            this.waste.Size = new System.Drawing.Size(100, 22);
            this.waste.TabIndex = 17;
            // 
            // recycle
            // 
            this.recycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recycle.Location = new System.Drawing.Point(613, 321);
            this.recycle.Name = "recycle";
            this.recycle.Size = new System.Drawing.Size(100, 22);
            this.recycle.TabIndex = 18;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(92, 257);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(181, 36);
            this.save.TabIndex = 19;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(92, 304);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(181, 36);
            this.back.TabIndex = 20;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(173, 169);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(100, 22);
            this.monthBox.TabIndex = 21;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.recycle);
            this.Controls.Add(this.waste);
            this.Controls.Add(this.gas);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.population);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.year);
            this.Controls.Add(this.recycled);
            this.Controls.Add(this.foodWaste);
            this.Controls.Add(this.elec);
            this.Controls.Add(this.gasoline);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.size);
            this.Controls.Add(this.month);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Input";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EcoFootprint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label pop;
        private System.Windows.Forms.Label gasoline;
        private System.Windows.Forms.Label elec;
        private System.Windows.Forms.Label foodWaste;
        private System.Windows.Forms.Label recycled;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.TextBox population;
        private System.Windows.Forms.TextBox bill;
        private System.Windows.Forms.TextBox gas;
        private System.Windows.Forms.TextBox waste;
        private System.Windows.Forms.TextBox recycle;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox monthBox;
    }
}