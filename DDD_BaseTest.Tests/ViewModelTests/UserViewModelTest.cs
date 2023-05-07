using DDD_Base.Domain.Entities;
using DDD_Base.Domain.Repositories;
using DDD_Base.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace DDD_BaseTest.Tests.ViewModelTests
{
    [TestClass]
    public class UserViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var user = new UserEntity(1, "TARO");

            var userMock = new Mock<IUserRepository>();
            userMock.Setup(x => x.GetUser()).Returns(user);
            var vm = new UserViewModel(userMock.Object);
            vm.Search();
            vm.IdText.Is("0001");
            vm.NameText.Is("TARO");

        }
    }
}
