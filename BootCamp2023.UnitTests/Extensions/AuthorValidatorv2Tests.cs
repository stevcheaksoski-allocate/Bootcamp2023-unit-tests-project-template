using BootCamp2023.Api.Common.Domain;
using BootCamp2023.Api.Common.Extensions;
using NUnit.Framework;
using System;

namespace BootCamp2023.UnitTests.Extensions
{
    [TestFixture]
    public class AuthorValidatorv2Tests
    {
        [Test]
        public void Author_Validator_V2_Not_Implemented_Exception_NOT_THROWN()
        {
            // Arrange
            var classUnderTest = new Author();

            // Act
            classUnderTest.ValidateDateOfBirth();
        }

        [Test]
        public void Author_Validator_V2_Is_Valid_BirthOfDate_Value()
        {
            // Arrange
            var classUnderTest = new Author();
            classUnderTest.DateOfBirth = default(DateTime);

            // Act && Assert
            Assert.Throws<Exception>(() => classUnderTest.ValidateDateOfBirth());
        }
    }
}
