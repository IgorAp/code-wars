using CodeWars.Kata.TribonacciSequence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeWars.Kata.Tests.TribonacciSequence
{
    public class XbonacciTests
    {
        [Theory]
        [InlineData(new double[] { 1, 1, 1 }, 10, new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 })]
        [InlineData(new double[] { 0, 0, 1 }, 10, new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 })]
        public void Xbonacci_CaculateTribonacci_WithSuccess(double[] input,int numberOfElements, double[] expected)
        {
            //Arrange
            var xbonacci = new Xbonacci();

            //Act
            double[] actual = xbonacci.CaculateTribonacci(input, numberOfElements);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
