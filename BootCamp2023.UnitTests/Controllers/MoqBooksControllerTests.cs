using BootCamp2023.Api.Common.Repositories;
using BootCamp2023.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace BootCamp2023.UnitTests.Controllers
{
    public class MoqBooksControllerTests
    {
        private BooksController ClassUnderTest;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            ClassUnderTest = new BooksController(new BooksRepository());
            var result = ClassUnderTest.Get(123);
            Assert.IsTrue(typeof(OkObjectResult) == result.GetType());
        }
    }
}