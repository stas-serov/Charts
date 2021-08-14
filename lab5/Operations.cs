using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace lab5
{
    public class Operations
    {
        public static Data generate (int size, int min, int max)
        {
            Random rd = new Random();
            Data dt = new Data(size);
            for(int i = 0; i < size; i++)
            {
                dt.y[i] = rd.Next(min, max);
                dt.x[i] = i + 1;
            }
            return dt;
        }
        public static Bitmap Circular(Color color, int width, int height, float [] array, string name)
        {
            Random rd = new Random();
            float sum = 0;
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format64bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            SolidBrush sb = new SolidBrush(color);
            g.FillRectangle(sb, 0, 0, width, height);
            int x = (int)(height * 0.1);
            int y = (int)(height * 0.1);
            Font font = new Font("Times New Roman", 14, FontStyle.Bold);
            foreach (float value in array)
                sum += value;
            float start_angle = 0, sweep_angle = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sweep_angle = array[i] / sum * 360;
                SolidBrush brush = new SolidBrush(color);
                brush.Color = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                g.FillPie(brush, x, y, (int)(height * 0.8), (int)(height * 0.8), start_angle, sweep_angle);
                g.DrawPie(System.Drawing.Pens.Black, x, y, (int)(height * 0.8), (int)(height * 0.8), start_angle, sweep_angle);
                start_angle += sweep_angle;
            }
            g.DrawString(name, font, Brushes.Black, width / 5, 5);
            g.SmoothingMode = SmoothingMode.HighQuality;
            return bmp;
        }
        public static Bitmap Bar(Color color, int width, int height, float[] array, string name)
        {
            Font font = new Font("Times New Roman", 14, FontStyle.Bold);
            Random rd = new Random();
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format64bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            float max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, 0, 0, width, height);
            float bar_space = 8;
            float bar_heigth = (float)((height * 0.9 - (array.Length * 8 + 1))/array.Length);
            float x = 0;
            float y = (float)(height * 0.1);
            for(int i = 0; i < array.Length; i++)
            {
                float w = (float)(width * 0.9 * array[i] / max);
                RectangleF rect = new RectangleF(x, y, w, bar_heigth);
                brush.Color = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                g.FillRectangle(brush, rect);
                g.DrawRectangle(System.Drawing.Pens.Black, x, y, w, bar_heigth);
                g.DrawString(array[i].ToString(), font, Brushes.Black, w + 2, y + (bar_heigth / 2));
                y += (bar_heigth + bar_space); 
            }
            g.DrawString(name, font, Brushes.Black, width / 5, 5);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            return bmp;
        }
    }
}
