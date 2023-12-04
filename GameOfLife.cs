namespace GameOfLife 
{
    class GameOfLife {
        public static void Main() {
            // Define a collection of living cells.
            Cell[] livingCells = {
                new(1, 1),
                new(1, 2),
                new(2, 1),
                new(3, 3),
                new(3, 1),
                new(10, 12),
                new(11, 12),
                new(11, 11),
                new(10, 13),
                new(12, 9),
                new(11, 9),
                new(10, 9)
            };

            // Create a new cell field with the initial living cells.
            var cellField = new CellField(livingCells);
            
            while(!cellField.IsGameOver())
            {
                Console.WriteLine(cellField.WriteOutCellField());
                cellField.Iterate();
            }
        }
    }
}