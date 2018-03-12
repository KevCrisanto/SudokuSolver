using SudokuSolver.Strategies;
using SudokuSolver.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Mapper mapper = new Mapper();
                BoardStateManager boardStateManager = new BoardStateManager();
                SolverEngine solverEngine = new SolverEngine(boardStateManager, mapper);
                FileReader fileReader = new FileReader();
                BoardDisplayer boardDisplayer = new BoardDisplayer();

                Console.Write("Enter the filename containing the sudoku puzzle: ");
                var filename = Console.ReadLine();

                var sudokuBoard = fileReader.ReadFile(filename);
                boardDisplayer.Display("Initial State", sudokuBoard);
                bool isSudokuSolved = solverEngine.Solve(sudokuBoard);
                boardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(isSudokuSolved
                    ? "Successfully solved puzzle!"
                    : "Unfortunately, our algorithms couldn't solve the sudoku puzzle");
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0} : {1}", "Sudoku puzzle cannot be solved because there was an error: ", ex.Message);
            }
        }
    }
}
