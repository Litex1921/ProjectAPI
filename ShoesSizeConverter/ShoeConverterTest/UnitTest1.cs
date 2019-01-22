using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoesSizeConverter;

namespace ShoeConverterTest
{
    [TestClass]
    public class UnitTest1
    {
        IShoesSizeConverter converter = new UsShoeSizeConverter();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(new ShoeSize("Size_7", 24.4), 
                converter.GetForCentimeters(24.4, ShoeCategories.Men));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var shoeSIze = converter.GetForCentimeters(24.4, ShoeCategories.Men);
            Console.WriteLine(shoeSIze.Name);
            Console.WriteLine(shoeSIze.SizeInCentimeters);
            Assert.AreEqual(new ShoeSize("Size_7", 24.4),
               converter.GetForCentimeters(25, ShoeCategories.Men));
        }


        [TestMethod]
        public void TestMethod3()
        {

            Assert.AreEqual(new ShoeSize("Size_6", 23.5),
               converter.GetForCentimeters(23.5, ShoeCategories.Men));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(new ShoeSize("Size_6", 23.5),
                   converter.GetForCentimeters(20, ShoeCategories.Men));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(new ShoeSize("Size_8", 25.4),
                   converter.GetForCentimeters(25.9, ShoeCategories.Men));
        }


      
    }
}
