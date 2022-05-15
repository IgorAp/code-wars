using CodeWars.Kata.FaultyOdometer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeWars.Kata.Tests.FaultyOdometer
{
    public class OdometerCalculatorTests
    {
        [Theory]
        [InlineData(13,12)]
        [InlineData(15,13)]
        [InlineData(2003, 1461)]
        [InlineData(2005, 1462)]
        [InlineData(1500, 1053)]
        [InlineData(55, 40)]
        public void OdometerCalculator_CalculateOdometerRealDistance_WithSuccess(int currentMiles,int expected)
        {
            //Arrange
            var odometerCalculator = new OdometerCalculator();

            //Act
            int actual = odometerCalculator.CalculateOdometerRealDistance(currentMiles);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OdometerCalculator_CalculateOdometerRealDistance_InvalidMiles()
        {
            //Arrange
            var odometerCalculator = new OdometerCalculator();
            int currentMiles = 0;

            //Act & //Assert
            Assert.Throws<ArgumentException>(() => odometerCalculator.CalculateOdometerRealDistance(currentMiles));
        }
    }
}
