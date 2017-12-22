namespace ProjectEuler.Tests
{
    using FluentAssertions;
    using Xunit;

    public class Problem023Tests
    {
        [Fact]
        public void Solve_WhenCalled_ProducesCorrectSolution()
        {
            int actual = new Problem023().Solve();

            actual.Should().Be(4179871);
        }
    }
}
