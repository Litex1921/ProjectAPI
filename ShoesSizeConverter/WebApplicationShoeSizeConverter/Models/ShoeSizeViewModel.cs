using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationShoeSizeConverter.Models
{
    public class ShoeSizeViewModel
    {
        public double SizeInCentimeters { get; set; }
        public string Name { get; set; }
        public ShoeSizeViewModel() { }

        public ShoeSizeViewModel (string name, double size)
        {
            this.SizeInCentimeters = size;
            this.Name = name;
        }
    }
}