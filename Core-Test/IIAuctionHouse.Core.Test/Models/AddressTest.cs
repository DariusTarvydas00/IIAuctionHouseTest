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

        #region Address Id property Unit test
        //Checks if Address Id property exists
        [Fact]
        public void Id_NoParam_Exists()
        {
            Assert.True(_address.GetType().GetProperty("Id") != null);    
        }

        // Checks if Address Id is integer
        [Fact]
        public void Id_Id_MustBeLong()
        {
            Assert.True(_address.Id is int);
        }

        // Checks if Address Id stores Id value
        [Fact]
        public void Id_SetId_StoresId()
        {
            _address.Id = 1;
            Assert.Equal(1, _address.Id);
        }

        // Checks if Address Id updates new Id value
        [Fact]
        public void Id_UpdateId_StoresNewId()
        {
            _address.Id = 1;
            _address.Id = 2;
            Assert.Equal(2, _address.Id);
        }
        #endregion

        #region Address Country property Unit test
        // Checks if Address contains Country property
        [Fact]
        public void Country_NoParam_Exists()
        {
            Assert.True(_address.GetType().GetProperty("Country") != null);
        }
        
        // Checks if Address Country property is saved and is a string
        [Fact]
        public void Country_SetCountry_IsStringAndStoresValue()
        {
            _address.Country = "Denmark";
            Assert.True(_address.Country is string);
        }
        
        // Checks if Address Country stores new Country value
        [Fact]
        public void Country_UpdateCountry_UpdatesNewCountryValue()
        {
            _address.Country = "Lithuania";
            _address.Country = "Denmark";
            Assert.Equal("Denmark", _address.Country);
        }

        #endregion

        #region Address City property Unit test

        // Checks if Address contains City property
        [Fact]
        public void City_NoParam_Exists()
        {
            Assert.True(_address.GetType().GetProperty("City") != null);
        }
        
        // Checks if Address City property is saved and is a string
        [Fact]
        public void City_SetCity_IsStringAndStoresValue()
        {
            _address.City = "Esbjerg";
            Assert.True(_address.City is string);
        }
        
        // Checks if Address Country stores new Country value
        [Fact]
        public void City_UpdateCity_UpdatesNewCityValue()
        {
            _address.Country = "Copenhagen";
            _address.Country = "Esbjerg";
            Assert.Equal("Esbjerg", _address.Country);
        }

        #endregion

        #region Address Street Name property Unit test

        // Checks if address contains Street name property
        [Fact]
        public void StreetName_NoParam_Exists()
        {
            Assert.True(_address.GetType().GetProperty("StreetName") != null);
        }
        
        // Checks if Address StreetName property is saved and is a string
        [Fact]
        public void StreetName_SetStreetName_IsStringAndStoresValue()
        {
            _address.StreetName = "Strandbygade";
            Assert.True(_address.StreetName is string);
        }
        
        // Checks if Address StreetName stores new StreetName value
        [Fact]
        public void StreetName_UpdateStreetName_UpdatesNewStreetNameValue()
        {
            _address.StreetName = "Strandbygade";
            _address.StreetName = "Skolegade";
            Assert.Equal("Skolegade", _address.StreetName);
        }
        

        #endregion

        #region Address Street Number property Unit test

        // Checks if Address contains Street Number property
        [Fact]
        public void StreetNumber_NoParam_Exists()
        {
            Assert.True(_address.GetType().GetProperty("StreetNumber") != null);
        }

        // Checks if Address Street Number is integer
        [Fact]
        public void StreetNumber_NoParam_isInteger()
        {
            Assert.True(_address.StreetNumber is int);
        }
        
        // Checks if Address StreetNumber stores value
        [Fact]
        public void StreetNumber_SetStreetNumber_StoresStreetNumber()
        {
            _address.StreetNumber = 43;
            Assert.Equal(43, _address.StreetNumber);
        }

        // Checks if Address StreetNumber updates new StreetNumber value
        [Fact]
        public void StreetNumber_UpdateStreetNumber_StoresNewStreetNumber()
        {
            _address.StreetNumber = 43;
            _address.StreetNumber = 34;
            Assert.Equal(34, _address.StreetNumber);
        }
        
        #endregion

        #region Address PostCode property Unit test
        
        // Checks if Address contains PostCode Property
        [Fact]
        public void PostCode_NoParam_Exists()
        {
            Assert.True(_address.GetType().GetProperty("PostCode") != null);
        }
        
        // Checks if Address Post Code is integer
        [Fact]
        public void PostCode_NoParam_isInteger()
        {
            Assert.True(_address.StreetNumber is int);
        }
        
        // Checks if Address PostCode stores PostCode value
        [Fact]
        public void PostCode_SetPostCode_StoresPostCode()
        {
            _address.PostCode = 6700;
            Assert.Equal(6700, _address.PostCode);
        }

        // Checks if Address PostCode updates new PostCode value
        [Fact]
        public void PostCode_UpdatePostCode_StoresNewPostCode()
        {
            _address.PostCode = 7600;
            _address.PostCode = 6700;
            Assert.Equal(6700, _address.PostCode);
        }
        #endregion
        
    }
}