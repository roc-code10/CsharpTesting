using BasicCSharpPart2Homework4;
using Xunit;

namespace Tests.BasicC_Part2Homework4
{
    public class FibonacciSumTests
    {
        [Fact]
        public void SumEvenValuedTermsUpToLimit_ReturnsCorrectSum()
        {
            //arrange
            int expectedSum = 798;

            //act
            int actualSum = FibonacciSum.SumEvenValuedTermsUpToLimit(1000);

            //assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}
