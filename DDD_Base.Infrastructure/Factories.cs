using DDD_Base.Domain;
using DDD_Base.Domain.Repositories;
using DDD_Base.Infrastructure.Fake;
using DDD_Base.Infrastructure.Postgre;

namespace DDD_Base.Infrastructure
{
    public static class Factories
    {
        public static IUserRepository CreateUser()
        {
            if (Shared.IsFake)
            {
                return new UserFake();
            }

            return new UserPostgre();
        }

        public static IAreaRepository CreateArea()
        {
            if (Shared.IsFake)
            {
                return new AreaFake();
            }

            return new AreaPostgre();
        }
    }
}
