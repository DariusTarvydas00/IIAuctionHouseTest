using System;
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

            #region Account Details Id property Unit test

            // Checks if Account Details Id property exists
            [Fact]
            public void Id_NoParam_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("Id") != null);
            }

            // Checks if AccDetails Id is integer
            [Fact]
            public void Id_NoParam_MustBeLong()
            {
                Assert.True(_accDetails.Id is int);
            }
            
            // Checks if AccDetails Id can be assigned
            [Fact]
            public void Id_SetId_StoresId()
            {
                _accDetails.Id = 1;
                Assert.Equal(1, _accDetails.Id);
            }
            
            // Checks if AccDetails Id can be updated
            [Fact]
            public void Id_UpdateId_StoresNewId()
            {
                _accDetails.Id = 1;
                _accDetails.Id = 2;
                Assert.Equal(2, _accDetails.Id);
            }
            #endregion
            
            #region Account Details PhoneNumber property Unit test

            // Checks if Account Details PhoneNumber property exists
            [Fact]
            public void PhoneNumber_NoParam_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("Id") != null);
            }

            // Checks if AccDetails PhoneNumber property is integer
            [Fact]
            public void PhoneNumber_NoParam_IsInteger()
            {
                Assert.True(_accDetails.Id is int);
            }
            
            // Checks if AccDetails PhoneNumber property can be stored
            [Fact]
            public void PhoneNumber_SetPhoneNumber_StoresPhoneNumber()
            {
                _accDetails.PhoneNumber = 123456789;
                Assert.Equal(123456789, _accDetails.PhoneNumber);
            }
            
            // Checks if AccDetails PhoneNumber property can be updated
            [Fact]
            public void PhoneNumber_UpdatePhoneNumber_StoresNewPhoneNumber()
            {
                _accDetails.PhoneNumber = 987654321;
                _accDetails.PhoneNumber = 123456789;
                Assert.Equal(123456789, _accDetails.PhoneNumber);
            }
            #endregion

            #region Account Details Email property Unit Test

            //Checks if Email property exists
            [Fact]
            public void Email_NoParam_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("Email") != null);
            }

            // Checks if Email property is stored
            [Fact]
            public void Email_SetEmail_StoresEmail()
            {
                _accDetails.Email = "test@test.com";
                Assert.Equal("test@test.com", _accDetails.Email);
            }
            
            // Checks if Email property is updated
            [Fact]
            public void Email_UpdateEmail_UpdatesEmail()
            {
                _accDetails.Email = "test@test.com";
                _accDetails.Email = "test2@test2.com";
                Assert.Equal("test2@test2.com", _accDetails.Email);
            }

            #endregion

            #region Account Details AccCreationDate property Unit Test
            
            //Checks if AccCreationDate property exists
            [Fact]
            public void AccCreationDate_NoParam_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("AccCreationDate") != null);
            }
            
            // Checks if Account Details AccCreationDate property is stored
            [Fact]
            public void AccCreationDate_SetAccCreationDate_StoresDate()
            {
                _accDetails.AccCreationDate = new DateTime(2021,11, 24);
                Assert.Equal(new DateTime(2021,11,24), _accDetails.AccCreationDate);
            }

            // Checks if Account Details AccCreationDate property is updated
            [Fact]
            public void AccCreationDate_UpdateAccCreationDate_UpdatesDate()
            {
                _accDetails.AccCreationDate = new DateTime(2021,11, 24);
                _accDetails.AccCreationDate = new DateTime(2021,11, 25);
                Assert.Equal(new DateTime(2021,11,25), _accDetails.AccCreationDate);
            }

            #endregion

            // Checks if Address property exists
            [Fact]
            public void Address_NoParam_Exists()
            {
                Assert.True(_accDetails.GetType().GetProperty("Address") != null);
            }
    }
}