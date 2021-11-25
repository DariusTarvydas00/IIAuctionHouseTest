using Core.Models;
using Xunit;

namespace IIAuctionHouse.Core.Test.Models
{
    public class ProprietaryTest
    {
        private Proprietary _proprietary;

        public ProprietaryTest()
        {
            _proprietary = new Proprietary();
        }

        // Checks if Proprietary can be initialized
        [Fact]
        public void Proprietary_CanBeInitialized()
        {
            Assert.NotNull(_proprietary);
        }


        #region Proprietary Id property Unit Test
        
        // Checks if Proprietary Id Property exists
        [Fact]
        public void Id_NoParam_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("Id") != null);
        }

        // Checks if Proprietary Id is integer
        [Fact]
        public void Id_NoParam_IsInteger()
        {
            Assert.True(_proprietary.Id is int);
        }
        
        // Checks if Proprietary Id property can be stored
        [Fact]
        public void Id_SetId_StoresId()
        {
            _proprietary.Id = 1;
            Assert.Equal(1,_proprietary.Id);
        }
        
        // Checks if Proprietary Id property can be updated
        [Fact]
        public void Id_UpdateId_UpdatesId()
        {
            _proprietary.Id = 1;
            _proprietary.Id = 2;
            Assert.Equal(2,_proprietary.Id);
        }

        #endregion

        #region Proprietary CadastreNumber property Unit Test
        
        // Checks if Proprietary CadastreNumber Exists
        // Cadastre Number is unique number which gives information about property
        [Fact]
        public void CadastreNumber_NoParam_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("CadastreNumber") != null);
        }

        //Checks if Proprietary CadasterNumber property can be stored
        [Fact]
        public void CadastreNumber_SetCadastreNumber_StoresCadastreNumber()
        {
            _proprietary.CadastreNumber = "123_012:12";
            Assert.Equal("123_012:12",_proprietary.CadastreNumber);
        }
        
        //Checks if Proprietary CadasterNumber property can be Updated
        [Fact]
        public void CadastreNumber_UpdateCadastreNumber_StoresCadastreNumber()
        {
            _proprietary.CadastreNumber = "123_012:12";
            _proprietary.CadastreNumber = "123_12:12";
            Assert.Equal("123_12:12",_proprietary.CadastreNumber);
        }

        #endregion

        #region Proprietary ForestEnterprise property Unit Test
        
        // Checks if Proprietary ForestryEnterprise property exists
        [Fact]
        public void ForestryEnterprise_NoParam_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("ForestryEnterprise") != null);
        }
        
        // Checks if Proprietary ForestEnterprise property stores value
        [Fact]
        public void ForestEnterprise_SetForestEnterprise_StoresForestEnterprise()
        {
            _proprietary.ForestryEnterprise = "Esbjerg Forest Enterprise";
            Assert.Equal("Esbjerg Forest Enterprise", _proprietary.ForestryEnterprise);
        }
        
        // Checks if Proprietary ForestEnterprise property updates new value
        [Fact]
        public void ForestEnterprise_UpdateForestEnterprise_UpdatesNewForestEnterprise()
        {
            _proprietary.ForestryEnterprise = "Esbjerg Forest Enterprise";
            _proprietary.ForestryEnterprise = "Copenhagen Forest Enterprise";
            Assert.Equal("Copenhagen Forest Enterprise", _proprietary.ForestryEnterprise);
        }

        #endregion

        #region Proprietray City property Unit Test
        
        // Checks if Proprietary City property exists
        [Fact]
        public void City_NoParam_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("City") != null);
        }
        
        //Checks if Proprietary City stores value
        [Fact]
        public void City_SetCity_StoresCity()
        {
            _proprietary.City = "Esbjerg";
            Assert.Equal("Esbjerg", _proprietary.City);
        }

        //Checks if Proprietary City updates new value
        [Fact]
        public void City_UpdatesCity_UpdatesNewCity()
        {
            _proprietary.City = "Esbjerg";
            _proprietary.City = "Copenhagen";
            Assert.Equal("Copenhagen", _proprietary.City);
        }
        #endregion

        #region Proprietary GeoLocationX property Unit Test
        
        // Checks if Proprietary GeoLocationX property exists
        [Fact]
        public void GeoLocationX_NoParam_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("GeoLocationX") != null);
        }
        
        //Checks if Proprietary GeoLocationX is type of double
        [Fact]
        public void GeoLocationX_NoParam_IsDouble()
        {
            Assert.True(_proprietary.GeoLocationX is double);
        }

        //Checks if Proprietary GeoLocationX stores value
        [Fact]
        public void GeoLocationX_SetGeoLocationX_StoresGeoLocationX()
        {
            _proprietary.GeoLocationX = 123.123;
            Assert.Equal(123.123, _proprietary.GeoLocationX);
        }

        //Checks if Proprietary GeoLocationX updates new value
        [Fact]
        public void GeoLocationX_UpdatesGeoLocationX_UpdatesNewGeoLocationX()
        {
            _proprietary.GeoLocationX = 321.321;
            _proprietary.GeoLocationX = 123.123;
            Assert.Equal(123.123, _proprietary.GeoLocationX);
        }
        
        #endregion

        #region Proprietary GeoLocationY property Unit Test

        // Checks if Proprietary GeoLocationY property exists
        [Fact]
        public void GeoLocationY_NoParam_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("GeoLocationY") != null);
        }
        
        //Checks if Proprietary GeoLocationY is type of double
        [Fact]
        public void GeoLocationY_NoParam_IsDouble()
        {
            Assert.True(_proprietary.GeoLocationY is double);
        }

        //Checks if Proprietary GeoLocationY stores value
        [Fact]
        public void GeoLocationY_SetGeoLocationY_StoresGeoLocationY()
        {
            _proprietary.GeoLocationY = 123.123;
            Assert.Equal(123.123, _proprietary.GeoLocationY);
        }

        //Checks if Proprietary GeoLocationY updates new value
        [Fact]
        public void GeoLocationY_UpdatesGeoLocationY_UpdatesNewGeoLocationY()
        {
            _proprietary.GeoLocationY = 321.321;
            _proprietary.GeoLocationY = 123.123;
            Assert.Equal(123.123, _proprietary.GeoLocationY);
        }


        #endregion
    }
}