using DDD_Base.Domain.Entities;
using DDD_Base.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace DDD_Base.Infrastructure.Fake
{
    internal sealed class AreaFake : IAreaRepository
    {
        public IReadOnlyList<AreaEntity> GetAreas()
        {
            return new List<AreaEntity> { new AreaEntity("1", "エリア０１")};
        }

    }
}
