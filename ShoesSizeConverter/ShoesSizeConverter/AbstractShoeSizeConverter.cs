using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesSizeConverter
{
    /// <summary>
    /// Class AbstractShoeSizeConverter inherid interface IShoesSizeConverter
    /// </summary>
    public class AbstractShoeSizeConverter : IShoesSizeConverter
    {
        private Dictionary<ShoeCategories, Dictionary<String, double>> Categories { get; set; }

        public AbstractShoeSizeConverter(Dictionary<ShoeCategories, Dictionary<String, double>> sizes)
        {
            this.Categories = sizes;
        }
       
        public List<ShoeSize> GetAll(ShoeCategories category)
        {
            return Categories[category].Select(pair => new ShoeSize(pair.Key, pair.Value)).ToList();
        }

        public ShoeSize GetForCentimeters(double centimeters, ShoeCategories category)
        {
            var shoeSizeDictionary = Categories[category];
            var reversedDictionary = Categories[category].ToDictionary(pair => pair.Value, pair => pair.Key);

            try
            {
                var exactMatch = reversedDictionary[centimeters];
                return new ShoeSize(exactMatch, centimeters);
            }
            catch (KeyNotFoundException e)
            {
                var ceilingCentimeters = Math.Ceiling(centimeters);
                var centimeterSizeList = shoeSizeDictionary.Values;

                if (ceilingCentimeters > centimeterSizeList.Last())
                {
                    var shoeSizeName = reversedDictionary[centimeterSizeList.Last()];
                    var shoeSizeCentimeters = shoeSizeDictionary[shoeSizeName];
                    return new ShoeSize(shoeSizeName, shoeSizeCentimeters);
                }
                else if (ceilingCentimeters < centimeterSizeList.First())
                {
                    var shoeSizeName = reversedDictionary[centimeterSizeList.First()];
                    var shoeSizeCentimeters = shoeSizeDictionary[shoeSizeName];
                    return new ShoeSize(shoeSizeName, shoeSizeCentimeters);
                }
                else
                {
                    var matchingPair = reversedDictionary.First(
                        pair =>
                        Math.Ceiling(pair.Key) == ceilingCentimeters
                        || Math.Floor(pair.Key) == Math.Floor(centimeters));
                    return new ShoeSize(matchingPair.Value, matchingPair.Key);
                }
            }
        }

        public double SizeOf(string name, ShoeCategories category)
        {
            throw new NotImplementedException();
        }
    }
}
