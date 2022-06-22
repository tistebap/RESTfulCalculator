using Calculator.Controllers;
using Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.UnitTests.Controllers
{
    public class CalculatorControllerTest
    {
        [Fact]
        public void Divide_ByZeroReturnUnprocessableEntityResult()
        {
            // Arrange
            var mockCalculatorService = new Mock<ICalculatorService>();
            var controller = new CalculatorController(mockCalculatorService.Object);

            // Act
            var response = controller.Divide(5,0);

            // Assert
            Assert.IsType<UnprocessableEntityResult>(response);
        }
    }
}
