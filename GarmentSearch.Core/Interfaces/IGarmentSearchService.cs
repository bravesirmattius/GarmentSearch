using GarmentSearch.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarmentSearch.Core.Interfaces
{
    public interface IGarmentSearchService
    {
        IEnumerable<Garment> SearchGarment(string searchCriteria);
    }
}

