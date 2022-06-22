namespace Calculator.Services
{
    /// <summary>
    /// Service for four basic operations (+, -, *, /). 
    /// </summary>
    public class CalculatorService : ICalculatorService
    {
        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second Number</param>
        /// <returns>The result of the operation</returns>
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// Divide two numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second Number</param>
        /// <returns>The result of the operation</returns>
        public double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second Number</param>
        /// <returns>The result of the operation</returns>
        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        /// <summary>
        /// Substract two numbers
        /// </summary>
        /// <param name="firstNumber">first number</param>
        /// <param name="secondNumber">second Number</param>
        /// <returns>The result of the operation</returns>
        public double Substract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
