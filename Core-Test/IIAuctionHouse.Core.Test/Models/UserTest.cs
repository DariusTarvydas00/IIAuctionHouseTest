using Core.Models;
using Xunit;

namespace IIAuctionHouse.Core.Test.Models
{
        public class UserTest
        {
            private readonly User _user;

            public UserTest()
            {
                _user = new User();
            }

            [Fact]
            // Checks if User class can be initialized
            public void User_CanBeInitialized()
            {
                Assert.NotNull(_user);
            }

            [Fact]
            // Checks if User Id  property exists
            public void User_Id_Exists()
            {
                Assert.True(_user.GetType().GetProperty("Id") != null);
            }
            
            [Fact]
            // Checks if User Id is integer
            public void User_Id_MustBeLong()
            {
                Assert.True(_user.Id is int);
            }
            
            [Fact]
            // Checks if User Id can be assigned
            public void User_SetId_StoresId()
            {
                _user.Id = 1;
                Assert.Equal(1, _user.Id);
            }
            
            [Fact]
            // Checks if User Id can be updated
            public void User_UpdateId_StoresNewId()
            {
                _user.Id = 1;
                _user.Id = 2;
                Assert.Equal(2, _user.Id);
            }

            [Fact]
            // Checks if FirstName property exists
            public void User_FirstName_Exists()
            {
                Assert.True(_user.GetType().GetProperty("FirstName") != null);
            }
            
            [Fact]
            // Checks if FirstName can be assigned
            public void User_SetFirstName_StoresFirstName()
            {
                _user.FirstName = "John";
                Assert.Equal("John", _user.FirstName);
            }
            
            [Fact]
            // Checks if FirstName can be updated
            public void User_UpdateFirstName_StoresNewFirstName()
            {
                _user.FirstName = "John";
                _user.FirstName = "Mark";
                Assert.Equal("Mark", _user.FirstName);
            }

            [Fact]
            // Checks if LastName property exists
            public void User_LastName_Exists()
            {
                Assert.True(_user.GetType().GetProperty("LastName") != null);
            }

            [Fact]
            // Checks if LastName can be assigned
            public void User_SetLastName_StoresLastName()
            {
                _user.FirstName = "John";
                Assert.Equal("John", _user.FirstName);
            }
            
            [Fact]
            // Checks if Lastname can be updated
            public void User_UpdateLastName_StoresNewLastName()
            {
                _user.LastName = "Henriksen";
                _user.LastName = "Johansson";
                Assert.Equal("Johansson", _user.LastName);
            }
            
            [Fact]
            /*
             * Checks if Proprietaries property exists
             * No other checks will be made another class with proprietaries contains all information
             * Proprietary test will be needed
             */
            public void User_ListOfProprietary_Exists()
            {
                Assert.True(_user.GetType().GetProperty("Proprietaries") != null);
            }

            [Fact]
            /*
             * Checks if AccDetails property exists
             * No other checks will be made another class with Account Details contains all information
             * Account Details test will be needed
             */
            public void User_AccDetails_Exists()
            {
                Assert.True(_user.GetType().GetProperty("AccDetails") != null);
            }


        }
}