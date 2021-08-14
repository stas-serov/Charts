using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// show form with information about author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void about_author_Click(object sender, EventArgs e)
        {
            FormAuthor f = new FormAuthor();
            f.ShowDialog();
        }
        /// <summary>
        /// show form to work with charts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FormPrimitives f = new FormPrimitives();
                f.ShowDialog();
            }
            if(radioButton2.Checked)
            {
                FormChart f = new FormChart();
                f.ShowDialog();
            }
        }
    }
}
