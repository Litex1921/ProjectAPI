using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoesSizeConverter;

namespace ConsoleShoeSizeConvertor
{
    class Program
    {
        /// <summary>
        /// With this main method we  we call out of all sizes the appropriate size
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IShoesSizeConverter converter = new UsShoeSizeConverter();        
            Console.WriteLine("Enter size in centimeters");
            var size = Double.Parse(Console.ReadLine());
            Console.WriteLine("The size in USA for men {0}",converter.GetForCentimeters(size, ShoeCategories.Men).Name);
            IShoesSizeConverter convert= new UkShoeSizeConverter();
            Console.WriteLine("The size in Uk for men {0}", convert.GetForCentimeters(size, ShoeCategories.Men).Name);
            IShoesSizeConverter convrt = new EuroShoeSizeConverter();
            Console.WriteLine("The size in Europe is for men {0}", convrt.GetForCentimeters(size, ShoeCategories.Men).Name);

            IShoesSizeConverter calculating = new UsShoeSizeConverter();
            Console.WriteLine("The size in USA for women {0}", calculating.GetForCentimeters(size, ShoeCategories.Women).Name);
            IShoesSizeConverter calc = new UkShoeSizeConverter();
            Console.WriteLine("The size in Uk for women {0}", calc.GetForCentimeters(size, ShoeCategories.Women).Name);
            IShoesSizeConverter calculate = new EuroShoeSizeConverter();
            Console.WriteLine("The size in Europe is for women {0}", calculate.GetForCentimeters(size, ShoeCategories.Women).Name);
        }
    }
}
