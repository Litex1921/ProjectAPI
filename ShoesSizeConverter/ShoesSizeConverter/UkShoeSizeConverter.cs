using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesSizeConverter
{
    /// <summary>
    /// This class inherid AbstactShoeSizeConverter
    /// </summary>
    public class UkShoeSizeConverter : AbstractShoeSizeConverter
    {
        /// <summary>
        /// Here we are introducing the measures in Uk size
        /// </summary>

        private static Dictionary<String, double> MensSizes { get; } = new Dictionary<string, double>() {
            { "Size_5.5", 23.5}, { "Size_6.5", 24.4}, { "Size_7.5", 25.4},{ "Size_8.5", 26.0},{ "Size_9.5", 27.0},{ "Size_10.5", 27.9},
            { "Size_11.5", 28.6},{ "Size_12.5", 29.4},{ "Size_13.5", 30.2},{ "Size_14.5", 31.0},{ "Size_15.5", 31.8}
        };

        private static Dictionary<String, double> WomensSizes { get; } = new Dictionary<string, double>() {
            { "Size_2", 20.8}, { "Size_3", 21.6}, { "Size_4", 22.5},{ "Size_5", 23.5},{ "Size_6", 24.1},{ "Size_7", 25.1},
            { "Size_8", 25.9},{ "Size_9", 26.7},{ "Size_10", 27.6}
        };

        private static Dictionary<ShoeCategories, Dictionary<String, double>> Categories = new Dictionary<ShoeCategories, Dictionary<string, double>>
        {
            {ShoeCategories.Men, MensSizes},
             {ShoeCategories.Women, WomensSizes}
        };
     
        public UkShoeSizeConverter() : base(Categories)
        { }        
    }
}
