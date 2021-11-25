using System.Collections.Generic;
using System.Linq;
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
        
        // Checks if GetAdminById returns selected Admin
        [Fact]
        public void GetAdmin_ById_ReturnsAdmin()
        {
            var mock = new Mock<IAdminService>();
            var fakeAdminList = new List<Admin>();
            var fakeAdmin = new Admin()
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "Admin",
            };
            fakeAdminList.Add(fakeAdmin);
            mock.Setup(s => s.GetAdminById(It.IsAny<int>())).Returns(fakeAdminList.Find(admin => admin.Id == 1));
            var sevice = mock.Object;
            Assert.Equal(fakeAdmin,sevice.GetAdminById(1));
        }
        
        // Checks if CreateAdmin is created and stored in a list
        [Fact]
        public void CreateAdmin_Admin_StoresAdmin()
        {
            var mock = new Mock<IAdminService>();
            var fakeAdmin = new Admin()
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "Admin",
                AccDetails = null,
                Proprietaries = null
            };
            mock.Setup(s => s.CreateAdmin("Admin", "Admin", null,null))
                .Returns(() => fakeAdmin);
            var service = mock.Object;
            Assert.Equal(fakeAdmin, service.CreateAdmin("Admin", "Admin", null, null));
        }
        
        // Checks if DeleteAdmin is deleted from list
        [Fact]
        public void DeleteAdmin_Id_DeletesAdmin()
        {
            var mock = new Mock<IAdminService>();
            var fakeAdminList = new List<Admin>();
            var fakeAdmin = new Admin()
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "Admin",
            };
            fakeAdminList.Add(fakeAdmin);
            mock.Setup(s => s.DeleteAdmin(It.IsAny<int>())).Returns(fakeAdminList.Find(admin => admin.Id == 1));
            var sevice = mock.Object;
            Assert.True(sevice.GetAdminById(1) == null);
        }
        
        // Checks if UpdateAdmin updates Admin information
        [Fact]
        public void UpdateAdmin_Admin_UpdatesAdminInfo()
        {
            var mock = new Mock<IAdminService>();
            var fakeAdminList = new List<Admin>();
            var fakeAdmin = new Admin()
            {
                Id = 1,
                FirstName = "NotAdmin",
                LastName = "NotAdmin"
            };
            fakeAdminList.Add(fakeAdmin);
            var updateAdmin = fakeAdminList.Find(admin => admin.Id == 1);
            updateAdmin = new Admin()
            {
                Id = 1,
                FirstName = "Admin",
                LastName = "Admin"
            };
            mock.Setup(s => s.UpdateAdmin(updateAdmin))
                .Returns(updateAdmin);
            var service = mock.Object;
            Assert.Equal(updateAdmin, service.UpdateAdmin(updateAdmin));
        }
    }
}