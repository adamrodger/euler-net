namespace ProjectEuler.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extension methods for <see cref="Int32"/>
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Finds the factor of the given number
        /// </summary>
        /// <param name="n">Number to factor</param>
        /// <returns>Factors</returns>
        public static ICollection<int> Factors(this int n)
        {
            int[] lowFactors = Enumerable.Range(1, (int)Math.Sqrt(n) + 1)
                                         .Where(i => n % i == 0)
                                         .Select(i => i)
                                         .ToArray();
            var factors = lowFactors.Concat(lowFactors.Reverse().Select(i => n / i));

            return new HashSet<int>(factors);
        }

        /// <summary>
        /// Generate all prime numbers up to n
        /// </summary>
        /// <param name="n">Limit</param>
        /// <returns>Primes up to n</returns>
        public static IEnumerable<int> PrimesUpTo(this int n)
        {
            return Enumerable.Range(2, n - 2)
                             .Aggregate(new List<int>(),
                             (primes, i) =>
                             {
                                 if (i.IsPrime(primes))
                                 {
                                     primes.Add(i);
                                 }
                             
                                 return primes;
                             });
        }

        /// <summary>
        /// Check if n is prime by trial division
        /// </summary>
        /// <param name="n">Number to check</param>
        /// <returns>Is n prime?</returns>
        public static bool IsPrime(this int n)
        {
            return Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i != 0);
        }

        /// <summary>
        /// Check if n is prime by trial division of the given known primes
        /// </summary>
        /// <param name="n">Number to check</param>
        /// <param name="primes">Existing known primes</param>
        /// <returns>Is n prime?</returns>
        private static bool IsPrime(this int n, ICollection<int> primes)
        {
            return Enumerable.Range(2, (int)Math.Sqrt(n) - 1)
                             .Where(primes.Contains)
                             .All(i => n % i != 0);
        }
    }
}
