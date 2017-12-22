namespace ProjectEuler.Tests
{
    using FluentAssertions;
    using Xunit;

    public class Problem043Tests
    {
        [Fact]
        public void Solve_WhenCalled_ProducesCorrectSolution()
        {
            long actual = new Problem043().Solve();

            actual.Should().Be(16695334890);
        }
    }
}
