using SudokuSolver.Workers;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Strategies
{
    class SolverEngine
    {
        private readonly BoardStateManager _boardStateManager;
        private readonly Mapper _mapper;

        public SolverEngine(BoardStateManager boardStateManager, Mapper mapper)
        {
            _boardStateManager = boardStateManager;
            _mapper = mapper;
        }

        public bool Solve(int[,] sudokuBoard)
        {
            List<IStrategy> strategies = new List<IStrategy>()
            {
                new SimpleMarkUpStrategy(_mapper),
                new NakedPairsStrategy(_mapper)
            };

            var currentState = _boardStateManager.GenerateState(sudokuBoard);
            var nextState = _boardStateManager.GenerateState(strategies.First().Solve(sudokuBoard));

            while(!_boardStateManager.IsSolved(sudokuBoard) && currentState != nextState)
            {
                currentState = nextState;

                foreach (var strategy in strategies)
                {
                    nextState = _boardStateManager.GenerateState(strategy.Solve(sudokuBoard));
                }
            }

            return _boardStateManager.IsSolved(sudokuBoard);
        }
    }
}
