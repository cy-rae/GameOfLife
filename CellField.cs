using GameOfLife.rules;

namespace GameOfLife
{

    /// <summary>
    /// Typically, the playing field is infinite. To test the rules of the game,
    /// this playing field is set to a 20x15 cell matrix. A living cell is
    /// represented as "0". A dead cell is represented as "X".
    /// </summary>
    public class CellField
    {
        public const int COLUMNS = 20;
        public const int ROWS = 15;
        private char[,] matrix = new char[COLUMNS, ROWS];

        public CellField(Cell[] livingCells)
        {
            for (int i = 0; i < COLUMNS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    // The current cell of the playing field will be marked as
                    // alive, if the array of living cell contains a cell with
                    // the same coordinates. 
                    if (livingCells.Any(cell => cell.col == i
                    && cell.row == j))
                        matrix[i, j] = 'O';

                    // Else, the current cell will be marked as dead. 
                    else
                        matrix[i, j] = 'X';
                }
            }
        }

        public void Iterate()
        {
            var newMatrix = new char[COLUMNS, ROWS];
            for(int col = 0; col < COLUMNS; col++)
            {
                for(int row = 0; row < ROWS; row++)
                {
                    var cell = new Cell(col, row);
                    newMatrix[col, row] = RulesUtils.GetNextState(cell, matrix);
                }
            }

            matrix = newMatrix;
        }


        /// <summary>
        /// Check if the game is over. The game is over if there is no living
        /// cell anymore.
        /// </summary>
        /// <returns>If the game is over, the method will return true. Else,
        /// the method will return false.</returns>
        public bool IsGameOver(){
            return !matrix.OfType<char>().Any(c => c == 'O');
        }

        /// <summary>
        /// Write out the whole playing field and return the resulting string.
        /// </summary>
        /// <returns>This method returns a string that represents the cell
        /// field.</returns>
        public string WriteOutCellField()
        {
            var sb = new System.Text.StringBuilder();

            for (int j = 0; j < ROWS; j++)
            {
                for (int i = 0; i < COLUMNS; i++)
                {
                    sb.Append(matrix[i, j]);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}