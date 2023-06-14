using pierwiastek_kwadratowy;
using Xunit;

namespace pierwiastek_kwadratowy.Tests
{
    public class PierwiastekTests
    {
        [Theory]
        [InlineData(2, 2, -4, 36, -2, 1)]
        [InlineData(1, -5, 6, 1, 2, 3)]
        [InlineData(1, 0, -4, 16, -2, 2)]
        public void ObliczPierwiastki_dwaMiejscaZerowe(int a, int b, int c, double expectedDelta, double expectedX1, double expectedX2)
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

            
        }
    }
}
