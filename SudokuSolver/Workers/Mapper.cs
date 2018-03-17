using SudokuSolver.Data;

namespace SudokuSolver.Workers
{
    class Mapper
    {
        public Map Find(int givenRow, int givenCol)
        {
            Map map = new Map();
            if (givenRow <= 2) { map.StartRow = 0; }
            else if (givenRow <= 5) { map.StartRow = 3; }
            else if (givenRow <= 8) { map.StartRow = 6; }

            if (givenCol <= 2) { map.StartCol = 0; }
            else if (givenCol <= 5) { map.StartCol = 3; }
            else if (givenCol <= 8) { map.StartCol = 6; }

            return map;
        }
    }
}
