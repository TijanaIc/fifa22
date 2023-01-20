namespace Fifa22.Tests
{
    public class Fifa22CalculatorTest
    {
        [Fact]
        public void CalculatorSum_Test()
        {
            int result = Fifa22.Library.Calculator.Sum(2, 3);
            Assert.Equal(5, result);
            Assert.True(5 == result);
        }
    }
}