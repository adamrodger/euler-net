namespace ProjectEuler.Tests.Utilities
{
    using System.Collections.Generic;
    using FluentAssertions;
    using ProjectEuler.Utilities;
    using Xunit;

    public class IntExtensionsTests
    {
        [Fact]
        public void Factors_WhenCalled_ReturnsFactors()
        {
            int[] expected = { 1, 3, 5, 9, 15, 45 };

            ICollection<int> actual = 45.Factors();

            actual.Should().Equal(expected);
        }

        [Fact]
        public void Primes_WhenCalled_ReturnsPrimesUpToLimit()
        {
            int[] expected = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71 };

            var actual = 72.PrimesUpTo();

            actual.Should().Equal(expected);
        }
    }
}
