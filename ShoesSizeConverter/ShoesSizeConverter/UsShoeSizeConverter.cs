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
    public class UsShoeSizeConverter : AbstractShoeSizeConverter
    {
        /// <summary>
        /// Here we are introducing the measures in US size
        /// </summary>
        private static Dictionary<String, double> MensSizes { get; } = new Dictionary<string, double>() {
            { "Size_6", 23.5}, { "Size_7", 24.4}, { "Size_8", 25.4},{ "Size_9", 26.0},{ "Size_10", 27.0},{ "Size_11", 27.9},
            { "Size_12", 28.6},{ "Size_13", 29.4},{ "Size_14", 30.2},{ "Size_15", 31.0},{ "Size_16", 31.8}
        };

        private static Dictionary<String, double> WomensSizes { get; } = new Dictionary<string, double>() {
            { "Size_4", 20.8}, { "Size_5", 21.6}, { "Size_6", 22.5},{ "Size_7", 23.5},{ "Size_8", 24.1},{ "Size_9", 25.1},
            { "Size_10", 25.9},{ "Size_11", 26.7},{ "Size_12", 27.6}
        };

        private static Dictionary<ShoeCategories, Dictionary<String, double>> Categories = new Dictionary<ShoeCategories, Dictionary<string, double>>
        {
            {ShoeCategories.Men,MensSizes},
            {ShoeCategories.Women,WomensSizes}
        };

        public UsShoeSizeConverter() : base(Categories)
        {}
    }
}
