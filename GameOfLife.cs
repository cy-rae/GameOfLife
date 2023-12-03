namespace cyrae.GameOfLife 
{
    class GameOfLife {
        public static void Main() {
            // Define a collection of living cells.
            Cell[] livingCells = [
                new(1, 1),
                new(1, 2),
                new(2, 1),
                new(3, 3),
            ];

            // Create a new cell field with the initial living cells.
            var cellField = new CellField(livingCells);
            
            cellField.IsGameOver();
            // Console.WriteLine(cellField.WriteOutPlayingField());
        }
    }
}