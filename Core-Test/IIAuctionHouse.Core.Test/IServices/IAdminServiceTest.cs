using System.Collections.Generic;
using Core.IServices;
using Core.Models;
using Moq;
using Xunit;

namespace IIAuctionHouse.Core.Test.IServices
{
    public class IAdminServiceTest
    {
        [Fact]
        public void IAdminServiceTest_IsAvailable()
        {
            var adminService = new Mock<IAdminService>().Object;
            Assert.NotNull(adminService);
        }

        // Checks if GetAllAdmins method return a list of all admins
        [Fact]
        public void GetAllAdmins_WithNoParam_ReturnsListOfAllAddresses()
        {
            var mock = new Mock<IAdminService>();
            var fakeAdminList = new List<Admin>();
            mock.Setup(s => s.GetAllAdmins()).Returns(fakeAdminList);
            var service = mock.Object;
            Assert.Equal(fakeAdminList, service.GetAllAdmins());
        }
    }
}