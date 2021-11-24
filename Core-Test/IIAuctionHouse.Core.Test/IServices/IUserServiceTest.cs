using System.Collections.Generic;
using Core.IServices;
using Core.Models;
using Moq;
using Xunit;

namespace IIAuctionHouse.Core.Test.IServices
{
    public class IUserServiceTest
    {
        [Fact]
        public void IUserServiceTest_IsAvailable()
        {
            var userService = new Mock<IUserService>().Object;
            Assert.NotNull(userService);
        }

        // Checks if GetAllUsers method return a list of all Users
        [Fact]
        public void GetAllUsers_WithNoParam_ReturnsListOfAllAddresses()
        {
            var mock = new Mock<IUserService>();
            var fakeUserList = new List<User>();
            mock.Setup(s => s.GetAllUsers()).Returns(fakeUserList);
            var service = mock.Object;
            Assert.Equal(fakeUserList, service.GetAllUsers());
        }
    }
}