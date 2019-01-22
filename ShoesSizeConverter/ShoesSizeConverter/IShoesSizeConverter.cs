using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesSizeConverter
{
    /// <summary>
    /// That is progmaning interface  
    /// </summary>
    public interface IShoesSizeConverter
    {
        /// <summary>
        /// This method get centimeters from console and get all category from ShoeCategories.
        /// </summary>
        /// <param name="centimeters"></param>
        /// <param name="category"></param>
        /// <returns>List of all Category shoe size </returns>
        ShoeSize GetForCentimeters(double centimeters, ShoeCategories category);
        /// <summary>
        /// Returns all ShoeSizes from a category.
        /// </summary>
        /// <param name="category">the category to retrieve</param>
        /// <returns>List of ShoeSizes</returns>
        List<ShoeSize> GetAll(ShoeCategories category);
        /// <summary>
        /// Returns the centimeters of a ShoeSize.
        /// </summary>
        /// <param name="name">Name of the ShoeSize</param>
        /// <param name="category">The category of the ShoeSize</param>
        /// <returns>The size of the ShoeSize</returns>
        double SizeOf(string name, ShoeCategories category);
    }
}
