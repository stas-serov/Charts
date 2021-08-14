using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab5
{
    public partial class FormPrimitives : Form
    {
        Data dt;
        public FormPrimitives()
        {
            InitializeComponent();
        }
        /// <summary>
        /// generation of chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_Click(object sender, EventArgs e)
        {
            if(((int)(numericUpDown_size.Value) <= 0) || ((int)numericUpDown_max.Value <= (int)numericUpDown_min.Value)) MessageBox.Show("Incorrect data!", "Error!");
            else
            {
                dt = Operations.generate((int)numericUpDown_size.Value, (int)numericUpDown_min.Value, (int)numericUpDown_max.Value);
                if (radioButton_bar.Checked) dt.type = 0;
                if (radioButton_pie.Checked) dt.type = 1;
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 2;
                dataGridView1.RowCount = dt.y.Length;
                for (int i = 0; i < 2; i++)
                {
                    dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[i].Width = 120;
                }
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].HeaderText = "x";
                dataGridView1.Columns[1].HeaderText = "y";
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1[0, i].Value = i+1;
                    dataGridView1[1, i].Value = dt.y[i];
                }
                pictureBox1.Enabled = true;
                button_sort.Enabled = true;
                pictureBox1.Invalidate();
            }
        }
        /// <summary>
        /// paint for pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (dt == null) return;
            Color color = Color.White;
            string name;
            Bitmap bmp = null;
            if(dt.type == 0)
            {
                name = "Столбчиковая диаграмма";
                bmp = Operations.Bar(color, pictureBox1.Width, pictureBox1.Height, (float[])dt.y.Clone(), name);
            }
            if (dt.type == 1)
            {
                name = "Круговая диаграмма";
                bmp = Operations.Circular(color, pictureBox1.Width, pictureBox1.Height, (float[])dt.y.Clone(), name);
            }
            Graphics g = e.Graphics;
            g.DrawImage(bmp, 0, 0);
        }
        /// <summary>
        /// load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrimitives_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            button_sort.Enabled = false;
        }
        /// <summary>
        /// sorting values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_sort_Click(object sender, EventArgs e)
        {
            Array.Sort(dt.y);
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = dt.y.Length;
            for (int i = 0; i < 2; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[i].Width = 120;
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "x";
            dataGridView1.Columns[1].HeaderText = "y";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[0, i].Value = i + 1;
                dataGridView1[1, i].Value = dt.y[i];
            }
            pictureBox1.Invalidate();
        }
    }
}
