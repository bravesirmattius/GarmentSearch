using GarmentSearch.Core.Interfaces;
using GarmentSearch.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarmentSearch.Repository.Garments
{
    public class GarmentRepository : IGetEntity<Garment, string>
    {
        public IEnumerable<Garment> GetEntities(string searchCriteria)
        {
            throw new NotImplementedException();
        }
    }
}
