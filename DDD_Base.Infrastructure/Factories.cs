using DDD_Base.Domain;
using DDD_Base.Domain.Repositories;
using DDD_Base.Infrastructure.Fake;
using DDD_Base.Infrastructure.Postgre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
