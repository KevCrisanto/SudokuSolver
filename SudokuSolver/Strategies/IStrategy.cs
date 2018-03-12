namespace SudokuSolver.Strategies
{
    interface IStrategy
    {
        int[,] Solve(int[,] sudokuBoard);

    }
}
