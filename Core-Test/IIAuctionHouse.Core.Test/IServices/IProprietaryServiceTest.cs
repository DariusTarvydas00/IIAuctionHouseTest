using System.Collections.Generic;
using Core.IServices;
using Core.Models;
using Moq;
using Xunit;

namespace IIAuctionHouse.Core.Test.IServices
{
    public class IProprietaryServiceTest
    {
        
        // Checks if Proprietary Service is available
        [Fact]
        public void IProprietaryService_IsAvailable()
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
        
        // Checks if GetProprietary by Id returns proprietary
        [Fact]
        public void GetProprietary_ById_ReturnsProprietary()
        {
            var mock = new Mock<IProprietaryService>();
            var fakeProprietaryList = new List<Proprietary>();
            var fakeProprietary = new Proprietary()
            {
                Id = 1,
                City = "Esbjerg",
                CadastreNumber = "123/123:02",
                ForestryEnterprise = "EsbjergEnterprise",
                GeoLocationX = 22.2222,
                GeoLocationY = 12.2222
            };
            fakeProprietaryList.Add(fakeProprietary);
            mock.Setup(s => s.GetProprietaryById(It.IsAny<int>())).Returns(fakeProprietaryList.Find(p => p.Id == 1));
            var service = mock.Object;
            Assert.Equal(fakeProprietary,service.GetProprietaryById(1));
        }
        
        // Checks if Proprietary is deleted
        [Fact]
        public void DeleteProprietary_ById_ReturnsNull()
        {
            var mock = new Mock<IProprietaryService>();
            var fakeProprietaryList = new List<Proprietary>();
            var fakeProprietary = new Proprietary()
            {
                Id = 1,
                City = "Esbjerg",
                CadastreNumber = "123/123:02",
                ForestryEnterprise = "EsbjergEnterprise",
                GeoLocationX = 22.2222,
                GeoLocationY = 12.2222
            };
            fakeProprietaryList.Add(fakeProprietary);
            mock.Setup(s => s.DeleteProprietary(It.IsAny<int>())).Returns<int>((id) => fakeProprietary);
            var service = mock.Object;
            Assert.True(service.GetProprietaryById(1) == null);
        }
        
        // Checks if Proprietary is Created and stored
        [Fact]
        public void CreateProprietary_Proprietary_ProprietaryIsCreated()
        {
            var mock = new Mock<IProprietaryService>();
            var fakeProprietary = new Proprietary()
            {
                Id = 1,
                City = "Esbjerg",
                CadastreNumber = "123/123:02",
                ForestryEnterprise = "EsbjergEnterprise",
                GeoLocationX = 22.2222,
                GeoLocationY = 12.2222
            };
            mock.Setup(s => s.CreateProprietary("Esbjerg", "123/123:02",
                    "EsbjergEnterprise", 22.2222, 12.2222))
                .Returns(() => fakeProprietary);
            var service = mock.Object;
            Assert.Equal(fakeProprietary,service.CreateProprietary("Esbjerg","123/123:02","EsbjergEnterprise",22.2222,12.2222));
        }
        
        // Checks if Proprietary is updated
        [Fact]
        public void UpdateProprietary_Proprietary_ProprietaryIsUpdated()
        {
            var mock = new Mock<IProprietaryService>();
            var fakeProprietaryList = new List<Proprietary>();
            var fakeProprietary = new Proprietary()
            {
                Id = 1,
                City = "Esbjerg",
                CadastreNumber = "123/123:02",
                ForestryEnterprise = "EsbjergEnterprise",
                GeoLocationX = 222.333,
                GeoLocationY = 222.311
            };
            fakeProprietaryList.Add(fakeProprietary);
            var updateProprietary = fakeProprietaryList.Find(p => p.Id == 1);
            updateProprietary = new Proprietary()
            {
                Id = 1,
                City = "Copenhagen",
                CadastreNumber = "123/123:02",
                ForestryEnterprise = "EsbjergEnterprise",
                GeoLocationX = 222.333,
                GeoLocationY = 222.311
            };
            mock.Setup(s=>s.UpdateProprietary(updateProprietary)).Returns(updateProprietary);
            var service = mock.Object;
            Assert.Equal(updateProprietary, service.UpdateProprietary(updateProprietary));
        }
    }
}