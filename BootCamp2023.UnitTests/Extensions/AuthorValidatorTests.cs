using BootCamp2023.Api.Common.Domain;
using BootCamp2023.Api.Common.Extensions;
using NUnit.Framework;
using System;

namespace BootCamp2023.UnitTests.ExtensionsTests
{
    [TestFixture]
    public class AuthorValidatorTests
    {
        [Test]
        public void AuthorValidator_Validation_is_NOT_SUCESS_Author_is_NULL()
        {
            // Arrange
            Author classUnderTest = null;

            // Act && Assert
            Assert.Throws<Exception>(() => classUnderTest.Validate());
        }

        [Test]
        public void AuthorValidator_Validation_is_NOT_SUCESS_FirstName_is_NULL()
        {
            // Arrange
            var classUnderTest = new Author();
            classUnderTest.FirstName = null;

            // Act
            var response = Assert.Throws<Exception>(() => classUnderTest.Validate());

            // Assert
            Assert.AreEqual(response.Message, "First name cannot be null or empty");
        }

        [Test]
        public void AuthorValidator_Validation_is_NOT_SUCESS_FirstName_is_Success()
        {
            // Arrange
            var classUnderTest = new Author();
            classUnderTest.FirstName = "Rl Greatix!";

            // Act
            var response = Assert.Throws<Exception>(() => classUnderTest.Validate());

            // Assert
            Assert.AreNotEqual(response.Message, "Author cannot be null");
            Assert.AreNotEqual(response.Message, "First name cannot be null or empty");
        }
    }
}




































//[Test]
//public void AuthorValidator_Validation_is_success()
//{
//    ClassUnderTest = new Author();
//    ClassUnderTest.FirstName = "RL";
//    ClassUnderTest.LastName = "Greatix";
//    ClassUnderTest.ImageUrl = "www.someurlstring.com";

//    Assert.DoesNotThrow(() => ClassUnderTest.Validate());
//}

//[Test]
//public void AuthorValidator_Should_Throw_Exception_CAN_NOT_BE_NULL()
//{
//    ClassUnderTest = null;
//    var expectedException = Assert.Throws<Exception>(() => ClassUnderTest.Validate());
//}

//[Test]
//public void AuthorValidator_Should_Throw_Exception_FirstName_CAN_NOT_BE_EMPTY()
//{
//    var exceptionMessage = "First name cannot be null or empty";
//    ClassUnderTest.FirstName = string.Empty;

//    var expectedException = Assert.Throws<Exception>(() => ClassUnderTest.Validate());

//    Assert.AreEqual(exceptionMessage, expectedException.Message);
//}

//[Test]
//[TestCase(null)]
//public void AuthorValidator_Should_Throw_Exception_FirstName_CAN_NOT_BE_NULL(string firstName)
//{
//    var exceptionMessage = "First name cannot be null or empty";
//    ClassUnderTest.FirstName = firstName;

//    var expectedException = Assert.Throws<Exception>(() => ClassUnderTest.Validate());

//    Assert.AreEqual(exceptionMessage, expectedException.Message);
//}
