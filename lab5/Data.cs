using System;

namespace lab5
{
    public class Data
    {
        public int [] x { get; set; }
        public float[] y { get; set; }
        public int type { get; set; }
        public Data(int size)
        {
            x = new int [size];
            y = new float[size];
            type = Convert.ToInt32(null);
        }
    }
}
