using Core.Models;
using Xunit;

namespace IIAuctionHouse.Core.Test.Models
{
    public class AddressTest
    {
        private Address _address;

        public AddressTest()
        {
            _address = new Address();
        }

        // Checks if Address class can be initialized
        [Fact]
        public void Address_CanBeInitialized()
        {
            Assert.NotNull(_address);
        }

        // Checks if Address Id is integer
        [Fact]
        public void Address_Id_MustBeLong()
        {
            Assert.True(_address.Id is int);
        }

        // Checks if Address Id stores Id value
        [Fact]
        public void Address_SetId_StoresId()
        {
            _address.Id = 1;
            Assert.Equal(1, _address.Id);
        }

        // Checks if Address Id updates new Id value
        [Fact]
        public void Address_UpdateId_StoresNewId()
        {
            _address.Id = 1;
            _address.Id = 2;
            Assert.Equal(2, _address.Id);
        }

        // Checks if Address contains City property
        [Fact]
        public void Address_City_Exists()
        {
            Assert.True(_address.GetType().GetProperty("City") != null);
        }

        // Checks if Address contains Country property
        [Fact]
        public void Address_Country_Exists()
        {
            Assert.True(_address.GetType().GetProperty("Country") != null);
        }
        
        // Checks if address contains Street name property
        [Fact]
        public void Address_StreetName_Exists()
        {
            Assert.True(_address.GetType().GetProperty("StreetName") != null);
        }

        // Checks if Address contains Street Number property
        [Fact]
        public void Address_StreetNumber_Exists()
        {
            Assert.True(_address.GetType().GetProperty("StreetNumber") != null);
        }
        
        // Checks if Address contains PostCode Property
        [Fact]
        public void Address_PostCode_Exists()
        {
            Assert.True(_address.GetType().GetProperty("PostCode") != null);
        }


    }
}