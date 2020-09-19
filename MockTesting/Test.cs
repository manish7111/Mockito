using Mocking;
using Moq;
using NUnit.Framework;

namespace MockTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// This Test is used for testing the method using mock object.
        /// </summary>
        [Test]
        public void TestCaseForImplementedMethod()
        {
            var mock = new Mock<Repository>();
            Bussiness bussiness = new Bussiness(mock.Object);
            Assert.AreEqual(4, bussiness.Addition(2, 2));
        }

        /// <summary>
        /// This Test is used for setting up the required non implemented method should return the given value.
        /// </summary>
        [Test]
        public void TestCaseForNotImplementedMethods()
        {
            var mock = new Mock<Repository>();
            mock.Setup(self => self.Sub(3, 2)).Returns(3);
            Bussiness bussiness = new Bussiness(mock.Object);
            Assert.AreEqual(3, bussiness.Substraction(3, 2));
        }
    }
}