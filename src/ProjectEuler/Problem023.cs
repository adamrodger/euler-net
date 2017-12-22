
namespace ProjectEuler
{
    using System.Linq;
    using Utilities;

    /// <summary>
    /// A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example,
    /// the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
    /// 
    /// A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this
    /// sum exceeds n.
    /// 
    /// As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum
    /// of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can
    /// be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis
    /// even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is
    /// less than this limit.
    /// 
    /// Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
    /// </summary>
    public class Problem023 : IProblemSolver
    {
        /// <inheritdoc />
        public int Number => 23;

        /// <inheritdoc />
        public int Solve()
        {
            int[] abundant = Enumerable.Range(1, 28123).Where(IsAbundant).ToArray();
            int[] sums = abundant.SelectMany(n => abundant, (n, m) => n + m).Where(i => i <= 28123).Distinct().ToArray();

            return Enumerable.Range(1, 28123).Except(sums).Sum();
        }

        private static bool IsAbundant(int n)
        {
            return n.Factors().Except(new[] { n }).Sum() > n;
        }
    }
}
