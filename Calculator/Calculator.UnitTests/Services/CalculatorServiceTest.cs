using Calculator.Services;

namespace Calculator.UnitTests.Services
{
    public class CalculatorServiceTest
    {
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, -2.5, -0.5)]
        public void Add(double firstNumber, double secondNumber, double expectedResult)
        {
            // Arrange
            var service = new CalculatorService();

            // Act
            var result = service.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(2, -2.5, 4.5)]
        public void Substract(double firstNumber, double secondNumber, double expectedResult)
        {
            // Arrange
            var service = new CalculatorService();

            // Act
            var result = service.Substract(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(2, -2.5, -0.8)]
        public void Divide(double firstNumber, double secondNumber, double expectedResult)
        {
            // Arrange
            var service = new CalculatorService();

            // Act
            var result = service.Divide(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, -2.5, -5)]
        public void Multiply(double firstNumber, double secondNumber, double expectedResult)
        {
            // Arrange
            var service = new CalculatorService();

            // Act
            var result = service.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}