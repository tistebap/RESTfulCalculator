using Microsoft.AspNetCore.Mvc.Testing;

namespace Calculator.IntegrationTests
{
    /// <summary>
    /// Integration test for the calculator service
    /// </summary>
    public class CalculatorTest
    : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public CalculatorTest(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/Calculator/add/1/2.5")]
        [InlineData("/Calculator/substract/1/2.5")]
        [InlineData("/Calculator/divide/1/2.5")]
        [InlineData("/Calculator/multiply/1/2.5")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); 
            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers?.ContentType?.ToString());
        }


        [Theory]
        [InlineData("1.0","2.5","3.5")]
        [InlineData("-1.0", "-2.5", "-3.5")]
        public async Task Get_AddReturnCorrectValue(string firstNumber, string secondNumber, string expectedResult)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"/calculator/add/{firstNumber}/{secondNumber}/");

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(expectedResult, response.Content.ReadAsStringAsync().Result);
        }

        [Theory]
        [InlineData("1.0", "2.5", "0.4")]
        [InlineData("-1.0", "-2.5", "0.4")]
        public async Task Get_DivideReturnCorrectValue(string firstNumber, string secondNumber, string expectedResult)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"/calculator/divide/{firstNumber}/{secondNumber}/");

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(expectedResult, response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task Get_DivideByZeroReturnUnprocessableEntity()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"/calculator/divide/5/0.0/");

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.UnprocessableEntity,response.StatusCode);
        }


        [Theory]
        [InlineData("1.0", "2.5", "2.5")]
        [InlineData("-1.0", "-2.5", "2.5")]
        [InlineData("5.0", "5", "25")]

        public async Task Get_MultiplyReturnCorrectValue(string firstNumber, string secondNumber, string expectedResult)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"/calculator/multiply/{firstNumber}/{secondNumber}/");

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(expectedResult, response.Content.ReadAsStringAsync().Result);
        }

        [Theory]
        [InlineData("1.0", "2.5", "-1.5")]
        [InlineData("-1.0", "-2.5", "1.5")]
        public async Task Get_SubstractReturnCorrectValue(string firstNumber, string secondNumber, string expectedResult)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync($"/calculator/substract/{firstNumber}/{secondNumber}/");

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(expectedResult, response.Content.ReadAsStringAsync().Result);
        }
        
    }
}