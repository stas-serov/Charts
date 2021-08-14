using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab5
{
    public partial class FormChart : Form
    {
        int count_series = 0, count_areas = 0, num_area1 = 0, num_area2 = 0;
        bool flag1 = false, flag2 = false; 
        Data dt;
        Random rd = new Random();
        public FormChart()
        {
            InitializeComponent();
        }
        /// <summary>
        /// clear chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();
            flag1 = false;
            flag2 = false;
            count_areas = 0;
            count_series = 0;
        }
        /// <summary>
        /// generate series for 2-nd area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_generate_area2_Click(object sender, EventArgs e)
        {
            if(((int)numericUpDown_size_area2.Value < 1) || ((int)numericUpDown_min_area2.Value >= (int)numericUpDown_max_area2.Value))
            {
                MessageBox.Show("Incorrect data!", "Error!");
                return;
            }
            dt = Operations.generate((int)numericUpDown_size_area2.Value, (int)numericUpDown_min_area2.Value, (int)numericUpDown_max_area2.Value);
            dataGridView_area2.Rows.Clear();
            dataGridView_area2.ColumnCount = 2;
            dataGridView_area2.RowCount = dt.y.Length;
            for (int i = 0; i < 2; i++)
            {
                dataGridView_area2.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView_area2.Columns[i].Width = 84;
            }
            dataGridView_area2.RowHeadersVisible = false;
            dataGridView_area2.Columns[0].HeaderText = "x";
            dataGridView_area2.Columns[1].HeaderText = "y";
            for (int i = 0; i < dataGridView_area2.RowCount; i++)
            {
                dataGridView_area2[0, i].Value = i + 1;
                dataGridView_area2[1, i].Value = dt.y[i];
            }
            if (flag2)
            {
                if ((chart.Series[count_series - 1].ChartType == SeriesChartType.Pie) || (comboBox_area2.SelectedIndex == 1))
                {
                    MessageBox.Show("You can't create one more chart, if there is pie chart!", "Error");
                    return;
                }
                Series series = new Series();
                count_series++;
                chart.Series.Add(series);
                chart.Series[count_series - 1].ChartArea = chart.ChartAreas[count_areas - 1].Name;
                chart.Series[count_series - 1].Name = count_series.ToString() + "series"; ;
                chart.Series[count_series - 1].Points.DataBindXY(dt.x, dt.y);
                if (comboBox_area2.SelectedIndex == 0)
                {
                    chart.Series[count_series - 1].ChartType = SeriesChartType.Bar;
                    chart.Series[count_series - 1].Color = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    chart.Series[count_series - 1].BackGradientStyle = GradientStyle.TopBottom;
                }
                else chart.Series[count_series - 1].ChartType = SeriesChartType.Pie;
                chart.Series[count_series - 1].Label = "#VALY";
                chart.Series[count_series - 1].IsValueShownAsLabel = true;
                chart.Series[count_series - 1].LegendText = "chart" + count_series.ToString();
            }
            if (!flag2)
            {
                ChartArea area = new ChartArea();
                count_areas++;
                area.Name = count_areas.ToString() + "Area";
                chart.ChartAreas.Add(area);
                num_area2 = count_areas - 1;
                chart.Titles.Add("");
                chart.Titles[num_area2].Text = "2-nd area";
                chart.Titles[num_area2].Font = new Font("Times New Roman", 14, FontStyle.Regular);
                chart.Titles[num_area2].Position.X = 50;
                chart.Titles[num_area2].Position.Y = 55;
                chart.ChartAreas[num_area2].AxisX.Title = "X";
                chart.ChartAreas[num_area2].AxisX.TitleAlignment = StringAlignment.Center;
                chart.ChartAreas[num_area2].AxisY.Title = "Y";
                chart.ChartAreas[num_area2].AxisY.TitleAlignment = StringAlignment.Center;
                chart.ChartAreas[num_area2].AxisX.TitleFont = new Font("Times New Roman", 10, FontStyle.Regular);
                chart.ChartAreas[num_area2].AxisY.TitleFont = new Font("Times New Roman", 10, FontStyle.Regular);
                Series series = new Series();
                count_series++;
                chart.Series.Add(series);
                chart.Series[count_series - 1].ChartArea = chart.ChartAreas[num_area2].Name;
                chart.Series[count_series - 1].Name = count_series.ToString() + "series";
                chart.Series[count_series - 1].Points.DataBindXY(dt.x, dt.y);
                if (comboBox_area2.SelectedIndex == 0)
                {
                    chart.Series[count_series - 1].ChartType = SeriesChartType.Bar;
                    chart.Series[count_series - 1].Color = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    chart.Series[count_series - 1].BackGradientStyle = GradientStyle.TopBottom;
                }
                else chart.Series[count_series - 1].ChartType = SeriesChartType.Pie;
                chart.Series[count_series - 1].Label = "#VALY";
                chart.Series[count_series - 1].IsValueShownAsLabel = true;
                chart.Series[count_series - 1].LegendText = "chart" + count_series.ToString();
                chart.Legends.Add(chart.Series[count_series - 1].LegendText);
                flag2 = true;
            }
        }
        /// <summary>
        /// generate series for 1-st area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_generate_area1_Click(object sender, EventArgs e)
        {
            if (((int)numericUpDown_size_area1.Value < 1) || ((int)numericUpDown_min_area1.Value >= (int)numericUpDown_max_area1.Value))
            {
                MessageBox.Show("Incorrect data!", "Error!");
                return;
            }
            dt = Operations.generate((int)numericUpDown_size_area1.Value, (int)numericUpDown_min_area1.Value, (int)numericUpDown_max_area1.Value);
            dataGridView_area1.Rows.Clear();
            dataGridView_area1.ColumnCount = 2;
            dataGridView_area1.RowCount = dt.y.Length;
            for (int i = 0; i < 2; i++)
            {
                dataGridView_area1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView_area1.Columns[i].Width = 84;
            }
            dataGridView_area1.RowHeadersVisible = false;
            dataGridView_area1.Columns[0].HeaderText = "x";
            dataGridView_area1.Columns[1].HeaderText = "y";
            for (int i = 0; i < dataGridView_area1.RowCount; i++)
            {
                dataGridView_area1[0, i].Value = i + 1;
                dataGridView_area1[1, i].Value = dt.y[i];
            }
            if (flag1)
            {
                if ((chart.Series[count_series - 1].ChartType == SeriesChartType.Pie) || (comboBox_area1.SelectedIndex == 1))
                {
                    MessageBox.Show("You can't create one more chart, if there is pie chart!", "Error");
                    return;
                }
                Series series = new Series();
                count_series++;
                chart.Series.Add(series);
                chart.Series[count_series - 1].ChartArea = chart.ChartAreas[num_area1].Name;
                chart.Series[count_series - 1].Name = count_series.ToString() + "series";
                chart.Series[count_series - 1].Points.DataBindXY(dt.x, dt.y);
                if (comboBox_area1.SelectedIndex == 0)
                {
                    chart.Series[count_series - 1].ChartType = SeriesChartType.Bar;
                    chart.Series[count_series - 1].Color = Color.FromArgb(rd.Next(0,255), rd.Next(0, 255), rd.Next(0, 255));
                    chart.Series[count_series - 1].BackGradientStyle = GradientStyle.TopBottom;
                }
                else chart.Series[count_series - 1].ChartType = SeriesChartType.Pie;
                chart.Series[count_series - 1].Label = "#VALY";
                chart.Series[count_series - 1].IsValueShownAsLabel = true;
                chart.Series[count_series - 1].LegendText = "chart" + count_series.ToString();
            }
            if (!flag1)
            {
                ChartArea area = new ChartArea();
                count_areas++;
                area.Name = "1-st area";
                chart.ChartAreas.Add(area);
                num_area1 = count_areas - 1;
                chart.Titles.Add("");
                chart.Titles[num_area1].Text = "1-st area";
                chart.Titles[num_area1].Font = new Font("Times New Roman", 14, FontStyle.Regular);
                chart.ChartAreas[num_area1].AxisX.Title = "X";
                chart.ChartAreas[num_area1].AxisX.TitleAlignment = StringAlignment.Center;
                chart.ChartAreas[num_area1].AxisY.Title = "Y";
                chart.ChartAreas[num_area1].AxisY.TitleAlignment = StringAlignment.Center;
                chart.ChartAreas[num_area1].AxisX.TitleFont = new Font("Times New Roman", 10, FontStyle.Regular);
                chart.ChartAreas[num_area1].AxisY.TitleFont = new Font("Times New Roman", 10, FontStyle.Regular);
                Series series = new Series();
                count_series++;
                chart.Series.Add(series);
                chart.Series[count_series - 1].ChartArea = chart.ChartAreas[num_area1].Name;
                chart.Series[count_series - 1].Name = count_series.ToString() + "series";
                chart.Series[count_series - 1].Points.DataBindXY(dt.x, dt.y);
                if (comboBox_area1.SelectedIndex == 0)
                {
                    chart.Series[count_series - 1].ChartType = SeriesChartType.Bar;
                    chart.Series[count_series - 1].Color = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    chart.Series[count_series - 1].BackGradientStyle = GradientStyle.TopBottom;
                }
                else chart.Series[count_series - 1].ChartType = SeriesChartType.Pie;
                chart.Series[count_series - 1].Label = "#VALY";
                chart.Series[count_series - 1].IsValueShownAsLabel = true;
                chart.Series[count_series - 1].LegendText = "chart" + count_series.ToString();
                flag1 = true;
                chart.Legends.Add(chart.Series[count_series - 1].LegendText);
            }
        }
    }
}
