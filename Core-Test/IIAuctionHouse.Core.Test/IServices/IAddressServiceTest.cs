using System.Collections.Generic;
using System.Linq;
using Core.IServices;
using Core.Models;
using Moq;
using Xunit;

namespace IIAuctionHouse.Core.Test.IServices
{
    public class IAddressServiceTest
    {
        // Checks if Address Object exists
        [Fact]
        public void IAddressService_IsAvailable()
        {
            var addressService = new Mock<IAddressService>().Object;
            Assert.NotNull(addressService);
        }

        // Checks if GetAddress method return a list
        [Fact]
        public void GetAllAddresses_WithNoParam_ReturnsListOfAllAddresses()
        {
            var mock = new Mock<IAddressService>();
            var fakeAddressList = new List<Address>();
            mock.Setup(s => s.GetAllAddresses()).Returns(fakeAddressList);
            var service = mock.Object;
            Assert.Equal(fakeAddressList, service.GetAllAddresses());
        }

        // Checks if GetAddressById return correct address information by Id
        [Fact]
        public void GetAddress_ById_ReturnsAddress()
        {
            var mock = new Mock<IAddressService>();
            var fakeAddressList = new List<Address>();
            var fakeAddress = new Address()
            {
                Id = 1,
                Country = "Lithuania",
                City = "Kaunas",
                PostCode = 45286,
                StreetName = "SomeStreet",
                StreetNumber = 23 
            };
            fakeAddressList.Add(fakeAddress);

            mock.Setup(s => s.GetAddressById(It.IsAny<int>())).Returns(fakeAddressList.Find(address => address.Id == 1));
            var service = mock.Object;
            Assert.Equal(fakeAddress, service.GetAddressById(1));
        }

        // Checks if Address Object from list is deleted
        [Fact]
        public void DeleteAddress_ById_AddressIsDeleted()
        {
            var mock = new Mock<IAddressService>();
            var fakeAddressList = new List<Address>();
            var fakeAddress1 = new Address()
            {
                Id = 1,
                Country = "Lithuania",
                City = "Kaunas",
                PostCode = 45286,
                StreetName = "SomeStreet",
                StreetNumber = 23
            };
            fakeAddressList.Add(fakeAddress1);

            mock.Setup(s => s.DeleteAddress(It.IsAny<int>())).Returns(fakeAddressList.Find(address => address.Id == 1));
            var service = mock.Object;
            Assert.True(service.GetAddressById(1) == null);
        }
        
        // Checks if New Address is added to list
        [Fact]
        public void CreateAddress_Address_IsCreatedAndAdded()
        {
            var mock = new Mock<IAddressService>();
            var fakeAddressList = new List<Address>();
            var fakeAddress1 = new Address()
            {
                Id = 1,
                Country = "Lithuania",
                City = "Kaunas",
                PostCode = 45286,
                StreetName = "SomeStreet",
                StreetNumber = 23
            };
            fakeAddressList.Add(fakeAddress1);
            mock.Setup(s => s.CreateAddress(It.IsAny<Address>()))
                .Returns(fakeAddressList.FirstOrDefault(address => address.Id == 1));
            var service = mock.Object;
            Assert.Equal(fakeAddress1, service.CreateAddress(fakeAddress1));
        }

        // Checks if Address is updated
        [Fact]
        public void UpdateAddress_Address_AddressIsUpdated()
        {
            var mock = new Mock<IAddressService>();
            var fakeAddressList = new List<Address>();
            var fakeAddress1 = new Address()
            {
                Id = 1,
                Country = "Lithuania",
                City = "Kaunas",
                PostCode = 45286,
                StreetName = "SomeStreet",
                StreetNumber = 23
            };
            var fakeAddress2 = new Address()
            {
                Id = 1,
                Country = "Denmark",
                City = "Esbjerg",
                PostCode = 6700,
                StreetName = "SomeStreet",
                StreetNumber = 23
            };
            fakeAddressList.Add(fakeAddress1);
            var updateFakeAddress1 = fakeAddressList.First(address => address.Id == 1);
            updateFakeAddress1 = fakeAddress2;
            mock.Setup(s => s.UpdateAddress(It.IsAny<Address>())).Returns(() => updateFakeAddress1);
            var service = mock.Object;
            Assert.Equal(fakeAddress2, service.UpdateAddress(fakeAddress2));
        }

    }
}