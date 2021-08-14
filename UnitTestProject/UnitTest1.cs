using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using lab5;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_method1()
        {
            bool expected = false;
            float[] array = { 5, 7, 3, 8, 9 };
            var bmp = Operations.Bar(Color.Black, 500, 500, array, "Столбчиковая диаграмма");
            if (bmp is Bitmap) expected = true;
            Assert.AreEqual(expected, true); ;
        }
        [TestMethod]
        public void test_method2()
        {
            bool expected = false;
            float[] array = { 1, 6, 9, 4, 6};
            var bmp = Operations.Circular(Color.Black, 500, 500, array, "Круговая диаграмма");
            if (bmp is Bitmap) expected = true;
            Assert.AreEqual(expected, true); ;
        }
    }
}
