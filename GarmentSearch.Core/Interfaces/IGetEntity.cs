using System;
using System.Collections.Generic;
using System.Text;

namespace GarmentSearch.Core.Interfaces
{
    public interface IGetEntity<Entity, SearchCriteria>
    {
        IEnumerable<Entity> GetEntities(SearchCriteria searchCriteria);
    }
}
