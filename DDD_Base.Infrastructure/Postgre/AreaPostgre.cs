using DDD_Base.Domain.Entities;
using DDD_Base.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Base.Infrastructure.Postgre
{
    internal sealed class AreaPostgre : IAreaRepository
    {
        public IReadOnlyList<AreaEntity> GetAreas()
        {
            throw new NotImplementedException();
        }
    }
}
