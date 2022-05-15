using CodeWars.Kata.IntegerDepth;
using System;
using Xunit;

namespace CodeWars.Kata.Tests.IntegerDepth
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(42,9)]
        [InlineData(1,10)]
        [InlineData(32,18)]
        public void Calculator_ComputeDepth_WithSuccess(int number, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            int actual = calculator.ComputeDepth(number);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculator_ComputeDepth_InvalidParameter()
        {
            //Arrange
            var calculator = new Calculator();

            //Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.ComputeDepth(0));
        }


    }
}
