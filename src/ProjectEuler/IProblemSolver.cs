
namespace ProjectEuler
{
    /// <summary>
    /// Solver for a Euler problem
    /// </summary>
    public interface IProblemSolver
    {
        /// <summary>
        /// The problem number
        /// </summary>
        int Number { get; }

        /// <summary>
        /// Solve the problem
        /// </summary>
        /// <returns>Solution</returns>
        int Solve();
    }
}
