using System;
using System.Collections.Generic;
using System.Linq;
using Core.IServices;
using Core.Models;
using Moq;
using Xunit;

namespace IIAuctionHouse.Core.Test.IServices
{
    public class IAccDetailsServiceTest
    {
<<<<<<< HEAD:Core-Test/IIAuctionHouse.Core.Test/IServices/IAccDetailsServiceTest.cs
        private readonly AccDetails _accDetailsService;

        public IAccDetailsServiceTest()
        {
            _accDetailsService = new AccDetails();
        }
=======
>>>>>>> IAccDetailsTest:Core-Test/IIAuctionHouse.Core.Test/IServices/IAccDetailsTest.cs

        // Checks if IAccDetails is not exists
        [Fact]
        public void IAccDetails_IsAvailable()
        {
            var accDetails = new Mock<IAccDetailsServiceTest>().Object;
            Assert.NotNull(accDetails);
        }

        // Checks if GetAllAccDetails method returns list of All Acc details
        [Fact]
        public void GetAllAccDetails_WithNoParam_ReturnListOfAllAddresses()
        {
            var mock = new Mock<IAccDetailsService>();
            var fakeAccDetailsList = new List<AccDetails>();
            mock.Setup(s => s.GetAllAccDetails()).Returns(fakeAccDetailsList);
            var service = mock.Object;
            Assert.Equal(fakeAccDetailsList, service.GetAllAccDetails());
        }
        
         // Checks if GetAccDetailsById return correct address information by Id
        [Fact]
        public void GetAccDetails_ById_ReturnsAddress()
        {
            var mock = new Mock<IAccDetails>();
            var fakeAccDetailsList = new List<AccDetails>();
            var fakeAccDetails = new AccDetails()
            {
                Id = 1,
                Address = new Address()
                {
                    City = "Esbjerg",
                    Country = "Denmark",
                    PostCode = 6700,
                    StreetName = "Strandbygade",
                    StreetNumber = 30
                },
                Email = "test@test.com",
                PhoneNumber = 123456789,
                AccCreationDate = new DateTime(2021,12,12)

            };
            fakeAccDetailsList.Add(fakeAccDetails);

            mock.Setup(s => s.GetAccDetailsById(It.IsAny<int>())).Returns(fakeAccDetailsList.Find(accountDetails => accountDetails.Id == 1));
            var service = mock.Object;
            Assert.Equal(fakeAccDetails, service.GetAccDetailsById(1));
        }

        // Checks if AccDetails Object is deleted from list
        [Fact]
        public void DeleteAccDetails_ById_AccDetailsIsDeleted()
        {
            var mock = new Mock<IAccDetails>();
            var fakeAccDetailsList = new List<AccDetails>();
            var fakeAccDetails = new AccDetails()
            {
                Id = 1,
                Email = "test@test.com",
                PhoneNumber = 123456789,
                AccCreationDate = new DateTime(2021,12,12)
            };
            fakeAccDetailsList.Add(fakeAccDetails);

            mock.Setup(s => s.DeleteAccDetails(It.IsAny<int>())).Returns(fakeAccDetailsList.Find(details => details.Id == 1));
            var service = mock.Object;
            Assert.True(service.GetAccDetailsById(1) == null);
        }
        
        // Checks if New AccDetails is created and added to list
        [Fact]
        public void AccDetails_NewAccDetails_IsCreatedAndAdded()
        {
<<<<<<< HEAD:Core-Test/IIAuctionHouse.Core.Test/IServices/IAccDetailsServiceTest.cs
            Assert.True(_accDetailsService.GetType().GetProperty("Address") != null);
=======
            var mock = new Mock<IAccDetails>();
            var fakeAccDetailsList = new List<AccDetails>();
            var fakeAccDetails1 = new AccDetails()
            {
                Id = 1,
                Email = "test@test.com",
                PhoneNumber = 123456789,
                AccCreationDate = new DateTime(2021,12,12)
            };
            fakeAccDetailsList.Add(fakeAccDetails1);
            mock.Setup(s => s.CreateAccDetails(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<string>(), It.IsAny<DateTime>()))
                .Returns(fakeAccDetailsList.FirstOrDefault(details => details.Id == 1));
            var service = mock.Object;
            Assert.Equal(fakeAccDetails1, service.CreateAccDetails(null,123456789,"test@test.com",new DateTime(2021,12,12)));
        }

        // Checks if AccDetails is updated
        [Fact]
        public void UpdateAccDetails_AccDetails_AccDetailsIsUpdated()
        {
            var mock = new Mock<IAccDetails>();
            var fakeAccDetailsList = new List<AccDetails>();
            var fakeAccDetails1 = new AccDetails()
            {
                Id = 1,
                Email = "test@test.com",
                PhoneNumber = 123456789,
                AccCreationDate = new DateTime(2021,12,12)
            };
            var fakeAccDetails2 = new AccDetails()
            {
                Id = 1,
                Email = "test@test.com",
                PhoneNumber = 987654321,
                AccCreationDate = new DateTime(2021,12,10)
            };
            fakeAccDetailsList.Add(fakeAccDetails1);
            var updateFakeAccDetails1 = fakeAccDetailsList.First(details => details.Id == 1);
            updateFakeAccDetails1 = fakeAccDetails2;
            mock.Setup(s => s.UpdateAccDetails(It.IsAny<AccDetails>())).Returns(() => updateFakeAccDetails1);
            var service = mock.Object;
            Assert.Equal(fakeAccDetails2, service.UpdateAccDetails(fakeAccDetails2));
>>>>>>> IAccDetailsTest:Core-Test/IIAuctionHouse.Core.Test/IServices/IAccDetailsTest.cs
        }
    }
}