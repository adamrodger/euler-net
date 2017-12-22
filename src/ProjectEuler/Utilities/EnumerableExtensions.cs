namespace ProjectEuler.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Extension methods for <see cref="IEnumerable{T}"/>
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Find all the permutations of all the items in the collection
        /// </summary>
        /// <typeparam name="T">Type of the items</typeparam>
        /// <param name="items">Collection items</param>
        /// <returns>Permutations in lexicographical order</returns>
        public static IEnumerable<ICollection<T>> Permutations<T>(this ICollection<T> items)
        {
            return items.Permutations(items.Count);
        }

        /// <summary>
        /// Find all the permutations of the given length from the items in the collection
        /// </summary>
        /// <typeparam name="T">Type of the items</typeparam>
        /// <param name="items">Collection items</param>
        /// <param name="length">Length of the permutations</param>
        /// <returns>Permutations in lexicographical order</returns>
        public static IEnumerable<ICollection<T>> Permutations<T>(this ICollection<T> items, int length)
        {
            if (length == 1)
            {
                return items.Select(t => new[] { t });
            }

            return items.Permutations(length - 1)
                        .SelectMany(t => items.Where(e => !t.Contains(e)).ToArray(),
                                    (t1, t2) => t1.Concat(new[] { t2 }).ToArray());
        }
    }
}
