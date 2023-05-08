using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Base.Domain.Entities
{
    public sealed class AreaEntity
    {
        public AreaEntity(string areaId, string areaName)
        {
            AreaId = areaId;
            AreaName = areaName;
        }

        public string AreaId { get; }
        public string AreaName { get; }
    }
}
