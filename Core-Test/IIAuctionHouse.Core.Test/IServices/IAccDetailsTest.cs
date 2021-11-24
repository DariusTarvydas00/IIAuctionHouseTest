using System.Collections.Generic;
using Core.IServices;
using Core.Models;
using Moq;
using Xunit;

namespace IIAuctionHouse.Core.Test.IServices
{
    public class IAccDetailsTest
    {
        private readonly AccDetails _accDetails;

        public IAccDetailsTest()
        {
            _accDetails = new AccDetails();
        }

        [Fact]
        public void IAccountDetails_IsAvailable()
        {
            var accDetails = new Mock<IAccDetailsTest>().Object;
            Assert.NotNull(accDetails);
        }

        // Checks if GetAllAccDetails method returns list of All Acc details
        [Fact]
        public void GetAllAccDetails_WithNoParam_ReturnListOfAllAddresses()
        {
            var mock = new Mock<IAccDetails>();
            var fakeAccDetailsList = new List<AccDetails>();
            mock.Setup(s => s.GetAllAccDetails()).Returns(fakeAccDetailsList);
            var service = mock.Object;
            Assert.Equal(fakeAccDetailsList, service.GetAllAccDetails());
        }
        
        // Checks if Address property exists
        [Fact]
        public void Address_WithNoParam_Exists()
        {
            Assert.True(_accDetails.GetType().GetProperty("Address") != null);
        }
    }
}