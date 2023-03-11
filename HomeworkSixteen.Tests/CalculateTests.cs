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
        public void GetOperator_ShouldReturnRightOperator(int option, string expected)
        {
            // Arrange

            // Act
            string actual = Calculate.GetOperator(option);

            // Assert
            Assert.That(actual, Is.SameAs(expected));
        }
    }
}
