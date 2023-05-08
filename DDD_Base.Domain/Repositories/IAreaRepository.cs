using DDD_Base.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Base.Domain.Repositories
{
    public interface IAreaRepository
    {
        IReadOnlyList<AreaEntity> GetAreas();
    }
}
