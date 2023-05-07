using DDD_Base.Domain.Entities;
using DDD_Base.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Base.Infrastructure.Postgre
{
    internal sealed class UserPostgre : IUserRepository
    {
        public UserEntity GetUser()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
