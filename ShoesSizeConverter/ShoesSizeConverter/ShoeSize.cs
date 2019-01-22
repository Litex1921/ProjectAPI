using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesSizeConverter
{
    public struct ShoeSize
    { 
        /// <summary>
        /// This method get and set name and size in centimeters 
        /// </summary>
        
        public double SizeInCentimeters { get; set; }
        public string Name { get; set; }

        public ShoeSize(string name, double size)
        {
            this.SizeInCentimeters = size;
            this.Name = name;
        }

    }
}
