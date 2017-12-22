namespace ProjectEuler
{
    using System.Linq;
    using Utilities;

    /// <summary>
    /// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly
    /// once. For example, 2143 is a 4-digit pandigital and is also prime.
    /// 
    /// What is the largest n-digit pandigital prime that exists?
    /// </summary>
    public class Problem041 : IProblemSolver<int>
    {
        /// <inheritdoc />
        public int Number => 41;

        /// <inheritdoc />
        public int Solve()
        {
            string input = "987654321";
            int result = default(int);

            while (result == default(int))
            {
                result = input.ToArray()
                              .Permutations()
                              .Select(chars => new string(chars.ToArray()))
                              .Select(int.Parse)
                              .FirstOrDefault(n => n.IsPrime());

                // try next set of pandigitals
                input = input.Substring(1);
            }

            return result;
        }
    }
}
