namespace ProjectEuler.Tests.Utilities
{
    using System.Collections.Generic;
    using FluentAssertions;
    using ProjectEuler.Utilities;
    using Xunit;

    public class EnumerableExtensionsTests
    {
        [Fact]
        public void Permutations_WhenCalled_ProducesPermutations()
        {
            char[] input = { 'a', 'b', 'c' };
            IEnumerable<char[]> expected = new[]
            {
                new[] { 'a', 'b', 'c' },
                new[] { 'a', 'c', 'b' },
                new[] { 'b', 'a', 'c' },
                new[] { 'b', 'c', 'a' },
                new[] { 'c', 'a', 'b' },
                new[] { 'c', 'b', 'a' }
            };

            var actual = input.Permutations();

            actual.ShouldAllBeEquivalentTo(expected);
        }
    }
}
