using DDD_Base.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Base.Domain.Repositories
{
    public interface IUserRepository
    {
        UserEntity GetUser();
        UserEntity GetUserById(int id);
        List<UserEntity> GetUsers();
    }
}
