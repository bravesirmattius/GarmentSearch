using System;
using System.Collections.Generic;
using System.Text;

namespace GarmentSearch.Core.Models
{
    public class Garment
    {
        public string StyleName { get; set; }

        public IEnumerable<StyleColour> Colours { get; set; }
    }


    public class StyleColour
    {
        public string StyleColourCode { get; set; }

        public string Name { get; set; }

        public IEnumerable<Pricing> Pricing { get; set; }
    }

    public class Pricing
    {
        public decimal Price { get; set; }
    }
}
