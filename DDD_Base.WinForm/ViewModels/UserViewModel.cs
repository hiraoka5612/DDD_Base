using DDD_Base.Domain.Entities;
using DDD_Base.Domain.Repositories;
using DDD_Base.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Base.WinForm.ViewModels
{
    public class UserViewModel:ViewModelBase
    {
        private IUserRepository _userRepository;
        private UserEntity _user;
        private IAreaRepository _areasRepository;

        public UserViewModel(): this(Factories.CreateUser(), Factories.CreateArea())
        {
            
        }

        public UserViewModel(IUserRepository userRepository, IAreaRepository areaRepository) {
            _userRepository = userRepository;
            _areasRepository = areaRepository;
            foreach (var area in _areasRepository.GetAreas()) {
                Areas.Add(new AreaEntity(area.AreaId, area.AreaName));
            }
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

        public object SelectedAreaId
        {
            get
            {
                return string.Empty;
            }
        }

        public BindingList<AreaEntity> Areas { get; set; } = new BindingList<AreaEntity>();

        public void Search()
        {
            _user =_userRepository.GetUser();
            base.OnPropertyChanged();
        }
    }
}
