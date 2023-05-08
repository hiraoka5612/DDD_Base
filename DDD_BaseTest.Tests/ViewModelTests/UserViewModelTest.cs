
using DDD_Base.Domain.Entities;
using DDD_Base.Domain.Repositories;
using DDD_Base.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace DDD_BaseTest.Tests.ViewModelTests
{
    [TestClass]
    public class UserViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var user = new UserEntity(1, "TARO");
            var area = new AreaEntity("a", "TARO");
            var areas = new List<AreaEntity>();
            areas.Add(area);
       

            var userMock = new Mock<IUserRepository>();
            userMock.Setup(x => x.GetUser()).Returns(user);
            var areaMock = new Mock<IAreaRepository>();
            areaMock.Setup(x  => x.GetAreas()).Returns(areas);
            var vm = new UserViewModel(userMock.Object, areaMock.Object);
            vm.Search();
            vm.IdText.Is("0001");
            vm.NameText.Is("TARO");

        }
    }
}
