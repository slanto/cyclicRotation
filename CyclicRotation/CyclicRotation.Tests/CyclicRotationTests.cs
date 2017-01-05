using CyclicRotation.Core;
using Xunit;

namespace CyclicRotation.Tests
{    
    public class CyclicRotationTests
    {
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 1, new int[] { 6, 3, 8, 9, 7 })]
        [InlineData(new int[] { }, 10, new int[] { })]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[] { 3, 8, -9, 7, 6 }, 100, new int[] { 3, 8, -9, 7, 6 })]
        public void CyclicRotation_RotatesGivenArrayProperly(int[] input, int k, int[] expected)
        {
            var sut = new Solution();

            var actual = sut.CyclicRotation(input, k);

            Assert.Equal(expected, actual);
        }
    }
}
