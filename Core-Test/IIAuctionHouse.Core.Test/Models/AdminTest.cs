using Core.Models;
using Xunit;

namespace IIAuctionHouse.Core.Test.Models
{
    public class AdminTest
    {
         private readonly Admin _admin;

            public AdminTest()
            {
                _admin = new Admin();
            }

            [Fact]
            // Checks if Admin class can be initialized
            public void Admin_CanBeInitialized()
            {
                Assert.NotNull(_admin);
            }

            [Fact]
            // Checks if Admin Id property exists
            public void Admin_Id_Exists()
            {
                Assert.True(_admin.GetType().GetProperty("Id") != null);
            }
            
            [Fact]
            // Checks if Admin Id is integer
            public void Admin_Id_MustBeLong()
            {
                Assert.True(_admin.Id is int);
            }
            
            [Fact]
            // Checks if Admin Id can be assigned
            public void Admin_SetId_StoresId()
            {
                _admin.Id = 1;
                Assert.Equal(1, _admin.Id);
            }
            
            [Fact]
            // Checks if Admin Id can be updated
            public void Admin_UpdateId_StoresNewId()
            {
                _admin.Id = 1;
                _admin.Id = 2;
                Assert.Equal(2, _admin.Id);
            }

            [Fact]
            // Checks if FirstName property exists
            public void Admin_FirstName_Exists()
            {
                Assert.True(_admin.GetType().GetProperty("FirstName") != null);
            }
            
            [Fact]
            // Checks if FirstName can be assigned
            public void Admin_SetFirstName_StoresFirstName()
            {
                _admin.FirstName = "John";
                Assert.Equal("John", _admin.FirstName);
            }
            
            [Fact]
            // Checks if FirstName can be updated
            public void Admin_UpdateFirstName_StoresNewFirstName()
            {
                _admin.FirstName = "John";
                _admin.FirstName = "Mark";
                Assert.Equal("Mark", _admin.FirstName);
            }

            [Fact]
            // Checks if LastName property exists
            public void Admin_LastName_Exists()
            {
                Assert.True(_admin.GetType().GetProperty("LastName") != null);
            }

            [Fact]
            // Checks if LastName can be assigned
            public void Admin_SetLastName_StoresLastName()
            {
                _admin.FirstName = "John";
                Assert.Equal("John", _admin.FirstName);
            }
            
            [Fact]
            // Checks if Lastname can be updated
            public void Admin_UpdateLastName_StoresNewLastName()
            {
                _admin.LastName = "Henriksen";
                _admin.LastName = "Johansson";
                Assert.Equal("Johansson", _admin.LastName);
            }
            
            [Fact]
            /*
             * Checks if Proprietaries property exists
             * No other checks will be made another class with proprietaries contains all information
             * Proprietary test will be needed
             */
            public void Admin_ListOfProprietary_Exists()
            {
                Assert.True(_admin.GetType().GetProperty("Proprietaries") != null);
            }

            [Fact]
            /*
             * Checks if AccDetails property exists
             * No other checks will be made another class with Account Details contains all information
             * Account Details test will be needed
             */
            public void Admin_AccDetails_Exists()
            {
                Assert.True(_admin.GetType().GetProperty("AccDetails") != null);
            }
    }
}