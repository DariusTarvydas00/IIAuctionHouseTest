using Core.Models;
using Xunit;

namespace IIAuctionHouse.Core.Test.Models
{
    public class AccDetailsTest
    {
         private readonly AccDetails _accDetails;

            public AccDetailsTest()
            {
                _accDetails = new AccDetails();
            }

            // Checks if AccDetails class can be initialized
            [Fact]
            public void AccDetails_CanBeInitialized()
            {
                Assert.NotNull(_accDetails);
            }

            // Checks if AccDetails Id  property exists
            [Fact]
            public void AccDetails_Id_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("Id") != null);
            }
            
            // Checks if AccDetails Id is integer
            [Fact]
            public void AccDetails_Id_MustBeLong()
            {
                Assert.True(_accDetails.Id is int);
            }
            
            // Checks if AccDetails Id can be assigned
            [Fact]
            public void AccDetails_SetId_StoresId()
            {
                _accDetails.Id = 1;
                Assert.Equal(1, _accDetails.Id);
            }
            
            // Checks if AccDetails Id can be updated
            [Fact]
            public void AccDetails_UpdateId_StoresNewId()
            {
                _accDetails.Id = 1;
                _accDetails.Id = 2;
                Assert.Equal(2, _accDetails.Id);
            }
            
            // Checks if Address property exists
            [Fact]
            public void AccDetails_Address_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("Address") != null);
            }

            // Checks if PhoneNumber property exists
            [Fact]
            public void AccDetails_PhoneNumber_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("PhoneNumber") != null);
            }
            
            //Checks if Email property exists
            [Fact]
            public void AccDetails_Email_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("Email") != null);
            }
            
             //Checks if AccCreationDate property exists
             [Fact]
            public void AccDetails_AccCreationDate_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("AccCreationDate") != null);
            }
    }
}