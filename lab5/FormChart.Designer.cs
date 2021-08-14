
namespace lab5
{
    partial class FormChart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_area1 = new System.Windows.Forms.ComboBox();
            this.button_generate_area1 = new System.Windows.Forms.Button();
            this.dataGridView_area1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_size_area1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_max_area1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_min_area1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_area2 = new System.Windows.Forms.ComboBox();
            this.button_generate_area2 = new System.Windows.Forms.Button();
            this.dataGridView_area2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_size_area2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_max_area2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_min_area2 = new System.Windows.Forms.NumericUpDown();
            this.button_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_area1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size_area1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max_area1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min_area1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_area2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size_area2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max_area2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min_area2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.MistyRose;
            this.chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart.BorderSkin.PageColor = System.Drawing.Color.Gray;
            this.chart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            this.chart.Location = new System.Drawing.Point(374, 9);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(583, 481);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_area1);
            this.groupBox1.Controls.Add(this.button_generate_area1);
            this.groupBox1.Controls.Add(this.dataGridView_area1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_size_area1);
            this.groupBox1.Controls.Add(this.numericUpDown_max_area1);
            this.groupBox1.Controls.Add(this.numericUpDown_min_area1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1-st area";
            // 
            // comboBox_area1
            // 
            this.comboBox_area1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_area1.FormattingEnabled = true;
            this.comboBox_area1.Items.AddRange(new object[] {
            "bar сhart",
            "pie chart"});
            this.comboBox_area1.Location = new System.Drawing.Point(15, 178);
            this.comboBox_area1.Name = "comboBox_area1";
            this.comboBox_area1.Size = new System.Drawing.Size(149, 27);
            this.comboBox_area1.TabIndex = 2;
            // 
            // button_generate_area1
            // 
            this.button_generate_area1.BackColor = System.Drawing.Color.DarkViolet;
            this.button_generate_area1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_generate_area1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_generate_area1.ForeColor = System.Drawing.SystemColors.Control;
            this.button_generate_area1.Location = new System.Drawing.Point(15, 39);
            this.button_generate_area1.Name = "button_generate_area1";
            this.button_generate_area1.Size = new System.Drawing.Size(149, 36);
            this.button_generate_area1.TabIndex = 10;
            this.button_generate_area1.Text = "Generate";
            this.button_generate_area1.UseVisualStyleBackColor = false;
            this.button_generate_area1.Click += new System.EventHandler(this.button_generate_area1_Click);
            // 
            // dataGridView_area1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_area1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_area1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_area1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_area1.Location = new System.Drawing.Point(179, 41);
            this.dataGridView_area1.Name = "dataGridView_area1";
            this.dataGridView_area1.ReadOnly = true;
            this.dataGridView_area1.Size = new System.Drawing.Size(168, 168);
            this.dataGridView_area1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Max value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Min value:";
            // 
            // numericUpDown_size_area1
            // 
            this.numericUpDown_size_area1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_size_area1.Location = new System.Drawing.Point(93, 146);
            this.numericUpDown_size_area1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown_size_area1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_size_area1.Name = "numericUpDown_size_area1";
            this.numericUpDown_size_area1.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown_size_area1.TabIndex = 10;
            this.numericUpDown_size_area1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_max_area1
            // 
            this.numericUpDown_max_area1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_max_area1.Location = new System.Drawing.Point(93, 114);
            this.numericUpDown_max_area1.Name = "numericUpDown_max_area1";
            this.numericUpDown_max_area1.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown_max_area1.TabIndex = 9;
            // 
            // numericUpDown_min_area1
            // 
            this.numericUpDown_min_area1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_min_area1.Location = new System.Drawing.Point(93, 81);
            this.numericUpDown_min_area1.Name = "numericUpDown_min_area1";
            this.numericUpDown_min_area1.Size = new System.Drawing.Size(71, 27);
            this.numericUpDown_min_area1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_area2);
            this.groupBox2.Controls.Add(this.button_generate_area2);
            this.groupBox2.Controls.Add(this.dataGridView_area2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDown_size_area2);
            this.groupBox2.Controls.Add(this.numericUpDown_max_area2);
            this.groupBox2.Controls.Add(this.numericUpDown_min_area2);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2-nd area";
            // 
            // comboBox_area2
            // 
            this.comboBox_area2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_area2.FormattingEnabled = true;
            this.comboBox_area2.Items.AddRange(new object[] {
            "bar сhart",
            "pie chart"});
            this.comboBox_area2.Location = new System.Drawing.Point(15, 178);
            this.comboBox_area2.Name = "comboBox_area2";
            this.comboBox_area2.Size = new System.Drawing.Size(149, 27);
            this.comboBox_area2.TabIndex = 2;
            // 
            // button_generate_area2
            // 
            this.button_generate_area2.BackColor = System.Drawing.Color.DarkViolet;
            this.button_generate_area2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_generate_area2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_generate_area2.ForeColor = System.Drawing.SystemColors.Control;
            this.button_generate_area2.Location = new System.Drawing.Point(15, 39);
            this.button_generate_area2.Name = "button_generate_area2";
            this.button_generate_area2.Size = new System.Drawing.Size(149, 36);
            this.button_generate_area2.TabIndex = 10;
            this.button_generate_area2.Text = "Generate";
            this.button_generate_area2.UseVisualStyleBackColor = false;
            this.button_generate_area2.Click += new System.EventHandler(this.button_generate_area2_Click);
            // 
            // dataGridView_area2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_area2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_area2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_area2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_area2.Location = new System.Drawing.Point(179, 38);
            this.dataGridView_area2.Name = "dataGridView_area2";
            this.dataGridView_area2.Size = new System.Drawing.Size(168, 168);
            this.dataGridView_area2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(48, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Max value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(13, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Min value:";
            // 
            // numericUpDown_size_area2
            // 
            this.numericUpDown_size_area2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_size_area2.Location = new System.Drawing.Point(93, 146);
            this.numericUpDown_size_area2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_size_area2.Name = "numericUpDown_size_area2";
            this.numericUpDown_size_area2.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown_size_area2.TabIndex = 10;
            this.numericUpDown_size_area2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_max_area2
            // 
            this.numericUpDown_max_area2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_max_area2.Location = new System.Drawing.Point(93, 114);
            this.numericUpDown_max_area2.Name = "numericUpDown_max_area2";
            this.numericUpDown_max_area2.Size = new System.Drawing.Size(71, 26);
            this.numericUpDown_max_area2.TabIndex = 9;
            // 
            // numericUpDown_min_area2
            // 
            this.numericUpDown_min_area2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_min_area2.Location = new System.Drawing.Point(93, 81);
            this.numericUpDown_min_area2.Name = "numericUpDown_min_area2";
            this.numericUpDown_min_area2.Size = new System.Drawing.Size(71, 27);
            this.numericUpDown_min_area2.TabIndex = 8;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.DarkViolet;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.button_clear.Location = new System.Drawing.Point(269, 454);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(99, 36);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(969, 502);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChart";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_area1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size_area1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max_area1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min_area1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_area2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size_area2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_max_area2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_min_area2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_size_area1;
        private System.Windows.Forms.NumericUpDown numericUpDown_max_area1;
        private System.Windows.Forms.NumericUpDown numericUpDown_min_area1;
        private System.Windows.Forms.DataGridView dataGridView_area1;
        private System.Windows.Forms.ComboBox comboBox_area1;
        private System.Windows.Forms.Button button_generate_area1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_area2;
        private System.Windows.Forms.Button button_generate_area2;
        private System.Windows.Forms.DataGridView dataGridView_area2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_size_area2;
        private System.Windows.Forms.NumericUpDown numericUpDown_max_area2;
        private System.Windows.Forms.NumericUpDown numericUpDown_min_area2;
        private System.Windows.Forms.Button button_clear;
    }
}