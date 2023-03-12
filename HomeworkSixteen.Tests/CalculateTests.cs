using NUnit.Framework;

namespace HomeworkSixteen.Tests
{
    public class CalculateTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "+")]
        [TestCase(2, "-")]
        [TestCase(3, "x")]
        [TestCase(4, "÷")]
        [TestCase(5, "")]
        public void GetOperator_ReturnCorrectOperator(int option, string expected)
        {
            // Arrange

            // Act
            string actual = Calculate.GetOperator(option);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
