namespace GameOfLife
{
    public struct Cell
    {
        public int col;
        public int row;

        public Cell(int columnIndex, int rowIndex)
        {
            this.col = columnIndex;
            this.row = rowIndex;
        }

        public readonly Cell[] GetNeighborCells()
        {
            Cell[] neighborCells = new Cell[8];
            neighborCells[0] = new Cell(col - 1, row - 1);
            neighborCells[1] = new Cell(col - 1, row);
            neighborCells[2] = new Cell(col - 1, row + 1);
            neighborCells[3] = new Cell(col, row - 1);
            neighborCells[4] = new Cell(col, row + 1);
            neighborCells[5] = new Cell(col + 1, row - 1);
            neighborCells[6] = new Cell(col + 1, row);
            neighborCells[7] = new Cell(col + 1, row + 1);

            return neighborCells;
        }
    }
}