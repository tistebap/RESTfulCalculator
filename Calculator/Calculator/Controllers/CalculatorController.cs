using Calculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    /// <summary>
    /// Calculator Api for four basic operations (+, -, *, /). 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
   
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second Number</param>
        /// <returns>The result of the operation</returns>
        [HttpGet("add/{firstNumber}/{secondNumber}")]
        public IActionResult Add(double firstNumber, double secondNumber)
        {
            return Ok(_calculatorService.Add(firstNumber, secondNumber));
        }

        /// <summary>
        /// Divide two numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second Number</param>
        /// <returns>The result of the operation</returns>
        [HttpGet("divide/{firstNumber}/{secondNumber}")]
        public IActionResult Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber.Equals(0))
            {
                return UnprocessableEntity();
            }
            return Ok(_calculatorService.Divide(firstNumber, secondNumber));
        }

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second Number</param>
        /// <returns>The result of the operation</returns>
        [HttpGet("multiply/{firstNumber}/{secondNumber}")]
        public IActionResult Multiply(double firstNumber, double secondNumber)
        {
            return Ok(_calculatorService.Multiply(firstNumber, secondNumber));
        }

        /// <summary>
        /// Substract two numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second Number</param>
        /// <returns>The result of the operation</returns>
        [HttpGet("substract/{firstNumber}/{secondNumber}")]
        public IActionResult Substract(double firstNumber, double secondNumber)
        {
            return Ok(_calculatorService.Substract(firstNumber,secondNumber));
        }

    }
}