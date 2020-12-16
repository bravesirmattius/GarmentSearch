using System;
using System.Collections.Generic;
using System.Text;

namespace GarmentSearch.Core.Models
{
    public class GarmentApiResponse
    {
        public IEnumerable<Garment> Items { get; set; }
    }
}
