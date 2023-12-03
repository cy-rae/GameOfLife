using System.Text;

namespace cyrae.GameOfLife
{

    /// <summary>
    /// Typically, the playing field is infinite. To test the rules of the game, this playing field is set to a 5x5 cell matrix. A living cell is represented as "0".
    /// A dead cell is represented as "X".
    /// </summary>
    public class CellField
    {
        private const int COLUMNS = 5;
        private const int ROWS = 5;
        private readonly char[,] matrix = new char[COLUMNS, ROWS];

        public CellField(Cell[] livingCells)
        {
            for (int i = 0; i < COLUMNS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    // The current cell of the playing field will be marked as alive, if the array of living cell contains a cell with the same coordinates. 
                    // Else, the current cell will be marked as dead. 
                    if (livingCells.Any(cell => cell.columnIndex == i && cell.rowIndex == j))
                        matrix[i, j] = 'O';
                    else
                        matrix[i, j] = 'X';
                }
            }
        }

        /// <summary>
        /// Write out the whole playing field and return the resulting string.
        /// </summary>
        /// <returns>This method returns a string that represents the cell field of the game of life.</returns>
        public string WriteOutPlayingField()
        {
            var sb = new StringBuilder();

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

        public bool IsGameOver(){
            var s = matrix.Cast<char>();
            Console.WriteLine(s);
            return true;
        }

        public char[,] GetPlayingField()
        {
            return matrix;
        }
    }
}