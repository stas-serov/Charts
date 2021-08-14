
namespace lab5
{
    partial class FormPrimitives
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_pie = new System.Windows.Forms.RadioButton();
            this.radioButton_bar = new System.Windows.Forms.RadioButton();
            this.numericUpDown_min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_sort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_pie);
            this.groupBox1.Controls.Add(this.radioButton_bar);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of diagram";
            // 
            // radioButton_pie
            // 
            this.radioButton_pie.AutoSize = true;
            this.radioButton_pie.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_pie.Location = new System.Drawing.Point(6, 78);
            this.radioButton_pie.Name = "radioButton_pie";
            this.radioButton_pie.Size = new System.Drawing.Size(85, 27);
            this.radioButton_pie.TabIndex = 2;
            this.radioButton_pie.TabStop = true;
            this.radioButton_pie.Text = "Pie chart";
            this.radioButton_pie.UseVisualStyleBackColor = true;
            // 
            // radioButton_bar
            // 
            this.radioButton_bar.AutoSize = true;
            this.radioButton_bar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_bar.Location = new System.Drawing.Point(6, 39);
            this.radioButton_bar.Name = "radioButton_bar";
            this.radioButton_bar.Size = new System.Drawing.Size(92, 27);
            this.radioButton_bar.TabIndex = 1;
            this.radioButton_bar.TabStop = true;
            this.radioButton_bar.Text = "Bar graph";
            this.radioButton_bar.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_min
            // 
            this.numericUpDown_min.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_min.Location = new System.Drawing.Point(276, 27);
            this.numericUpDown_min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_min.Name = "numericUpDown_min";
            this.numericUpDown_min.Size = new System.Drawing.Size(71, 27);
            this.numericUpDown_min.TabIndex = 2;
            this.numericUpDown_min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_max
            // 
            this.numericUpDown_max.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_max.Location = new System.Drawing.Point(276, 60);
            this.numericUpDown_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_max.Name = "numericUpDown_max";
            this.numericUpDown_max.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown_max.TabIndex = 3;
            this.numericUpDown_max.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_size.Location = new System.Drawing.Point(276, 92);
            this.numericUpDown_size.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown_size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown_size.TabIndex = 4;
            this.numericUpDown_size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(196, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(196, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(231, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 240);
            this.dataGridView1.TabIndex = 8;
            // 
            // button_generate
            // 
            this.button_generate.BackColor = System.Drawing.Color.DarkViolet;
            this.button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_generate.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_generate.ForeColor = System.Drawing.SystemColors.Control;
            this.button_generate.Location = new System.Drawing.Point(258, 136);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(89, 36);
            this.button_generate.TabIndex = 9;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = false;
            this.button_generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // button_sort
            // 
            this.button_sort.BackColor = System.Drawing.Color.DarkViolet;
            this.button_sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sort.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sort.ForeColor = System.Drawing.SystemColors.Control;
            this.button_sort.Location = new System.Drawing.Point(258, 178);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(89, 36);
            this.button_sort.TabIndex = 10;
            this.button_sort.Text = "Sort";
            this.button_sort.UseVisualStyleBackColor = false;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(353, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 384);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // FormPrimitives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(744, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_size);
            this.Controls.Add(this.numericUpDown_max);
            this.Controls.Add(this.numericUpDown_min);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormPrimitives";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagram (graphic primitives)";
            this.Load += new System.EventHandler(this.FormPrimitives_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_pie;
        private System.Windows.Forms.RadioButton radioButton_bar;
        private System.Windows.Forms.NumericUpDown numericUpDown_min;
        private System.Windows.Forms.NumericUpDown numericUpDown_max;
        private System.Windows.Forms.NumericUpDown numericUpDown_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}