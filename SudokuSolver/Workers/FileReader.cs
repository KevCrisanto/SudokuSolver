using System;
using System.IO;
using System.Linq;

namespace SudokuSolver.Workers
{
    class FileReader
    {
        public int[,] ReadFile(string filename)
        {
            int[,] board = new int[9, 9];
            try
            {
                var boardLines = File.ReadAllLines(filename);

                int row = 0;
                foreach(var boardLine in boardLines)
                {
                    string[] boardLineElements = boardLine.Split('|').Skip(1).Take(9).ToArray();

                    int col = 0;
                    foreach(var boardLineElement  in boardLineElements)
                    {
                        board[row, col] = boardLineElement.Equals(" ") ? 0 : Convert.ToInt16(boardLineElement);
                        col++;
                    }
                    row++;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Something went wring while reading the file");
            }
            return board;
        }
    }
}
