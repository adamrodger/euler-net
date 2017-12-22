
namespace ProjectEuler
{
    /// <summary>
    /// Solver for a Euler problem
    /// </summary>
    /// <typeparam name="T">Type of the solution</typeparam>
    public interface IProblemSolver<out T>
    {
        /// <summary>
        /// The problem number
        /// </summary>
        int Number { get; }

        /// <summary>
        /// Solve the problem
        /// </summary>
        /// <returns>Solution</returns>
        T Solve();
    }
}
