using System.Collections.Generic;
using Core.IServices;
using Core.Models;
using Moq;
using Xunit;

namespace IIAuctionHouse.Core.Test.IServices
{
    public class IProprietaryServiceTest
    {
        [Fact]
        public void IProprietaryServiceTest_IsAvailable()
        {
            var proprietaryService = new Mock<IProprietaryService>().Object;
            Assert.NotNull(proprietaryService);
        }

        // Checks if GetAllProprietaries method return a list of all proprietaries
        [Fact]
        public void GetAllProprietaries_WithNoParam_ReturnsListOfAllAddresses()
        {
            var mock = new Mock<IProprietaryService>();
            var fakeProprietaryList = new List<Proprietary>();
            mock.Setup(s => s.GetAllProprietaries()).Returns(fakeProprietaryList);
            var service = mock.Object;
            Assert.Equal(fakeProprietaryList, service.GetAllProprietaries());
        }
    }
}