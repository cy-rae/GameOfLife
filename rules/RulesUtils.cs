using GameOfLife;

namespace GameOfLife.rules
{
    public static partial class RulesUtils
    {
        /// <summary>
        /// Compute the next state of the passed cell. It depends on the
        /// neighbor cells.
        /// </summary>
        /// <param name="cell">The next state of this cell will be
        /// computed.</param>
        /// <param name="matrix">This matrix contains the current states of each
        /// cell.</param>
        /// <returns>Returns a char that represents the next state of the
        /// passed cell.</returns>
        public static char GetNextState(Cell cell, char[,] matrix)
        {
            // Get the number of living neighbor cells.
            int numberOfLivingNeighborCells
                = CountLivingNeighborCells(cell, matrix);

            // The program will continue depending on the current state of the
            // cell.
            if (matrix[cell.col, cell.row] == 'O')
            {
                return GetNextStateOfLivingCell(numberOfLivingNeighborCells);
            }
            else
            {
                return GetNextStateOfDeadCell(numberOfLivingNeighborCells);
            }
        }

        /// <summary>
        /// Count the number of living neighbor cells of the passed cell.
        /// </summary>
        /// <param name="cell">The living neighbor cells of this cell will be
        /// counted.</param>
        /// <param name="matrix">This matrix contains the current state of the
        /// neighbor cells.</param>
        /// <returns>Returns the number of living neighbor cells.</returns>
        private static int CountLivingNeighborCells(Cell cell, char[,] matrix)
        {
            // Get the states of each neighbor.
            char[] statesOfNeighborCells
                = GetCurrentStatesOfNeighborCells(cell, matrix);

            // Count the living cells.
            return statesOfNeighborCells.Where(
                cell => cell.Equals('O')).ToArray().Length;
        }

        /// <summary>
        /// Get the states of the neighbor cells of the passed cell.
        /// </summary>
        /// <param name="cell">This parameter specifies the currently
        /// watched cell.</param>
        /// <param name="matrix">This parameter specifies the cell
        /// field.</param>
        /// <returns>Returns an array of chars that represent the state of the
        /// neighbor cells.</returns>
        private static char[] GetCurrentStatesOfNeighborCells(Cell cell,
            char[,] matrix)
        {
            // First get all neighbor cells.
            Cell[] neighborCells = cell.GetNeighborCells();

            // Collect the current states of each neighbor cell.
            var states = new char[8];
            for (int i = 0; i < neighborCells.Length; i++)
            {
                states[i] = GetCurrentState(neighborCells[i], matrix);
            }

            return states;
        }

        /// <summary>
        /// Get the current state of the passed cell.
        /// </summary>
        /// <param name="cell">This parameter specifies a cell.</param>
        /// <param name="matrix">This matrix contains the current states of all
        /// cells.</param>
        /// <returns>Returns the current state of the passed cell.</returns>
        private static char GetCurrentState(Cell cell, char[,] matrix)
        {
            // If index of cell is out of matrix bound, the state of the cell
            // will be representated as dead.
            if (cell.col < 0
                || cell.col > CellField.COLUMNS - 1
                || cell.row < 0
                || cell.row> CellField.ROWS - 1)
                return 'X';

            return matrix[cell.col, cell.row];
        }
    }
}