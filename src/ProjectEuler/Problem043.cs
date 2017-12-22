namespace ProjectEuler
{
    using System.Linq;
    using Utilities;

    /// <summary>
    /// The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits
    /// 0 to 9 in some order, but it also has a rather interesting sub-string divisibility property.
    /// 
    /// Let d1 be the 1st digit, d2 be the 2nd digit, and so on. In this way, we note the following:
    /// 
    /// d2*d3*d4=406 is divisible by 2
    /// d3*d4*d5=063 is divisible by 3
    /// d4*d5*d6=635 is divisible by 5
    /// d5*d6*d7=357 is divisible by 7
    /// d6*d7*d8=572 is divisible by 11
    /// d7*d8*d9=728 is divisible by 13
    /// d8*d9*d10=289 is divisible by 17
    /// 
    /// Find the sum of all 0 to 9 pandigital numbers with this property.
    /// </summary>
    public class Problem043 : IProblemSolver<long>
    {
        /// <summary>
        /// The problem number
        /// </summary>
        public int Number => 43;

        /// <summary>
        /// Solve the problem
        /// </summary>
        /// <returns>Solution</returns>
        public long Solve()
        {
            var result = "0123456789".ToArray()
                                     .Permutations()
                                     .Select(chars => new string(chars.ToArray()))
                                     .Where(s => int.Parse(s.Substring(1, 3)) % 2 == 0 &&
                                                 int.Parse(s.Substring(2, 3)) % 3 == 0 &&
                                                 int.Parse(s.Substring(3, 3)) % 5 == 0 &&
                                                 int.Parse(s.Substring(4, 3)) % 7 == 0 &&
                                                 int.Parse(s.Substring(5, 3)) % 11 == 0 &&
                                                 int.Parse(s.Substring(6, 3)) % 13 == 0 &&
                                                 int.Parse(s.Substring(7, 3)) % 17 == 0)
                                     .Select(long.Parse)
                                     .Sum();
            
            return result;
        }
    }
}
