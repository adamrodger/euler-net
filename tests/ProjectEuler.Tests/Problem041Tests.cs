namespace ProjectEuler.Tests
{
    using FluentAssertions;
    using Xunit;

    public class Problem041Tests
    {
        [Fact]
        public void Solve_WhenCalled_ProducesCorrectSolution()
        {
            int actual = new Problem041().Solve();

            actual.Should().Be(7652413);
        }
    }
}
