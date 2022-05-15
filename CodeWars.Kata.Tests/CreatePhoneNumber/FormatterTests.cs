using CodeWars.Kata.CreatePhoneNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeWars.Kata.Tests.CreatePhoneNumber
{
    public class FormatterTests
    {
        [Fact]
        public void Formatter_CreatePhoneNumber_Success()
        {
            // Arrange
            var formatter = new Formatter();
            var expected = "(123) 456-7890";

            // Act
            string actual = formatter.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
