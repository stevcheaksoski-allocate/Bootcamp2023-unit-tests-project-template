using BootCamp2023.Api.Common.Repositories;
using BootCamp2023.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace BootCamp2023.UnitTests.Controllers
{
    public class BooksControllerTests
    {
        private BooksController ClassUnderTest;

        [SetUp]
        public void Setup()
        {
            ClassUnderTest = new BooksController(new BooksRepository());
        }

        [Test]
        public void Test()
        {
            var result = ClassUnderTest.Get(123);
            Assert.IsTrue(typeof(OkObjectResult) == result.GetType());
        }
    }
}