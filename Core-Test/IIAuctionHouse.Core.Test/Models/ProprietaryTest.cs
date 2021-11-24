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

        // Checks if Proprietary Id Property exists
        [Fact]
        public void Proprietary_Id_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("Id") != null);
        }

        // Checks if Proprietary Id is integer
        [Fact]
        public void Proprietary_Id_IsInteger()
        {
            Assert.True(_proprietary.Id is int);
        }

        // Checks if Proprietary CadastreNumber Exists
        // Cadastre Number is unique number which gives information about property
        [Fact]
        public void Proprietary_CadastreNumber_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("CadastreNumber") != null);
        }

        // Checks if Proprietary ForestryEnterprise propert exists
        [Fact]
        public void Proprietary_ForestryEnterprise_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("ForestryEnterprise") != null);
        }

        // Checks if Proprietary City property exists
        [Fact]
        public void Proprietary_City_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("City") != null);
        }

        // Checks if Proprietary GeoLocationX property exists
        [Fact]
        public void Proprietary_GeoLocationX_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("GeoLocationX") != null);
        }

        // Checks if Proprietary GeoLocationY property exists
        [Fact]
        public void Proprietary_GeoLocationY_Exists()
        {
            Assert.True(_proprietary.GetType().GetProperty("GeoLocationY") != null);
        }
    }
}