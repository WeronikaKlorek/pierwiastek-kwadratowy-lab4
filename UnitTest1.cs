using pierwiastek_kwadratowy;
using Xunit;

namespace pierwiastek_kwadratowy.Tests
{
    public class PierwiastekTests
    {
        [Theory]
        [InlineData(1, -4, 4, 0, 2, double.NaN)]
        [InlineData(1, -5, 6, 1, 2, 3)]
        [InlineData(1, 0, -4, 16, -4, double.NaN)]
        public void ObliczPierwiastki_ShouldReturnCorrectResults(int a, int b, int c, double expectedDelta, double expectedX1, double expectedX2)
        {
            // Arrange
            Pierwiastek pierwiastek = new Pierwiastek();

            // Act
            pierwiastek.obliczPierwiastki(a, b, c);
            double actualDelta = pierwiastek.obliczDelte(a, b, c);
            double actualX1 = pierwiastek.x1;
            double actualX2 = pierwiastek.x2;

            // Assert
            Assert.Equal(expectedDelta, actualDelta);
            Assert.Equal(expectedX1, actualX1);
            Assert.Equal(expectedX2, actualX2);

            // Additional assertion for NaN values
            Assert.True(double.IsNaN(actualX1));
            Assert.True(double.IsNaN(actualX2));
        }
    }
}
