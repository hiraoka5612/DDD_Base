using DDD_Base.Domain.Entities;
using DDD_Base.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace DDD_Base.Infrastructure.Fake
{
    internal sealed class UserFake : IUserRepository
    {
        public UserEntity GetUser()
        {
            return new UserEntity(1, "TARO");
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
