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
    public class EuroShoeSizeConverter : AbstractShoeSizeConverter
    {    /// <summary>
         /// Here we are introducing the measures in Euro size
         /// </summary>

        private static Dictionary<String, double> MensSizes { get; } = new Dictionary<string, double>() {
            { "Size_39", 23.5}, { "Size_40", 24.4}, { "Size_41", 25.4},{ "Size_42", 26.0},{ "Size_43", 27.0},{ "Size_44", 27.9},
            { "Size_45", 28.6},{ "Size_46", 29.4},{ "Size_47", 30.2},{ "Size_48", 31.0},{ "Size_49", 31.8}
        };

        private static Dictionary<String, double> WomensSizes { get; } = new Dictionary<string, double>() {
            { "Size_35", 20.8}, { "Size_36", 21.6}, { "Size_37", 22.5},{ "Size_38", 23.5},{ "Size_39", 24.1},{ "Size_40", 25.1},
            { "Size_41", 25.9},{ "Size_42", 26.7},{ "Size_43", 27.6}
        };

        private static Dictionary<ShoeCategories, Dictionary<String, double>> Categories = new Dictionary<ShoeCategories, Dictionary<string, double>>
        {
            {ShoeCategories.Men, MensSizes},
             {ShoeCategories.Women, WomensSizes}
        };
      
        public EuroShoeSizeConverter() : base(Categories)
        { }

    }
}
