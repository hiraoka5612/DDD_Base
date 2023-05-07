using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Base.Domain.Entities
{
    public sealed class UserEntity
    {
        public UserEntity(int id, string name)
        {
            Id = id;

            Name = name;

        }

        public int Id { get;  }
        public string Name { get; }
    }
}
