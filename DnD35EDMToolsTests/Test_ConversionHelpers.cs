using DnD35EDMTools.Helpers;

namespace DnD35EDMToolsTests
{
    public class ConversionHelpersTests
    {
        [Fact]
        public void Test_ConvertFeetAndInchesToInches()
        {
            // Arrange
            string feetAndInches = "6'1\"";

            // Act
            var result = ConversionHelper.ConvertFeetAndInchesToInches(feetAndInches);

            // Assert
            Assert.Equal(73, result);
        }

        [Fact]
        public void Test_ConvertInchesToFeetAndInches()
        {
            // Arrange
            int inches = 73;

            // Act
            var result = ConversionHelper.ConvertInchesToFeetAndInches(inches);

            // Assert
            Assert.Equal("6'1\"", result);
        }

        [Fact]
        public void Test_ConvertFeetAndInchesToCentimeters()
        {
            // Arrange
            string feetAndInches = "6'1\"";

            // Act
            var result = ConversionHelper.ConvertFeetAndInchesToCentimeters(feetAndInches);

            // Assert
            Assert.Equal(185.42, result, 2); // Allowing for some precision error
        }

        [Fact]
        public void Test_ConvertCentimetersToFeetAndInches()
        {
            // Arrange
            double centimeters = 185.42;

            // Act
            var result = ConversionHelper.ConvertCentimetersToFeetAndInches(centimeters);

            // Assert
            Assert.Equal("6'1\"", result);
        }
    }
}
