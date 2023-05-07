using DDD_Base.Domain.Entities;
using DDD_Base.Domain.Repositories;
using DDD_Base.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Base.WinForm.ViewModels
{
    public class UserViewModel:ViewModelBase
    {
        private IUserRepository _userRepository;
        private UserEntity _user;

        public UserViewModel(): this(Factories.CreateUser())
        {
            
        }

        public UserViewModel(IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        public string IdText { get
            {
                return _user?.Id.ToString().PadLeft(4, '0');
            }
        }
        public string NameText { get { 
                return _user?.Name.ToString();
            } 
        }

        public void Search()
        {
            _user =_userRepository.GetUser();
            base.OnPropertyChanged();
        }
    }
}
