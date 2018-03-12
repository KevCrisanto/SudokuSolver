using SudokuSolver.Data;

namespace SudokuSolver.Workers
{
    class Mapper
    {
        public Map Find(int givenRow, int givenCol)
        {
            Map map = new Map();
            if ((givenRow >= 0 && givenRow <= 2) && (givenCol >= 0 && givenCol <= 2))
            {
                map.StartRow = 0;
                map.StartCol = 0;
            }
            else if ((givenRow >= 0 && givenRow <= 2) && (givenCol >= 3 && givenCol <= 5))
            {
                map.StartRow = 0;
                map.StartCol = 3;
            }
            else if ((givenRow >= 0 && givenRow <= 2) && (givenCol >= 6 && givenCol <= 8))
            {
                map.StartRow = 0;
                map.StartCol = 6;
            }

            else if ((givenRow >= 3 && givenRow <= 5) && (givenCol >= 0 && givenCol <= 2))
            {
                map.StartRow = 3;
                map.StartCol = 0;
            }
            else if ((givenRow >= 3 && givenRow <= 5) && (givenCol >= 3 && givenCol <= 5))
            {
                map.StartRow = 3;
                map.StartCol = 3;
            }
            else if ((givenRow >= 3 && givenRow <= 5) && (givenCol >= 6 && givenCol <= 8))
            {
                map.StartRow = 3;
                map.StartCol = 6;
            }

            else if ((givenRow >= 6 && givenRow <= 8) && (givenCol >= 0 && givenCol <= 2))
            {
                map.StartRow = 6;
                map.StartCol = 0;
            }
            else if ((givenRow >= 6 && givenRow <= 8) && (givenCol >= 3 && givenCol <= 5))
            {
                map.StartRow = 6;
                map.StartCol = 3;
            }
            else if ((givenRow >= 6 && givenRow <= 8) && (givenCol >= 6 && givenCol <= 8))
            {
                map.StartRow = 6;
                map.StartCol = 6;
            }

            return map;
        }
    }
}
