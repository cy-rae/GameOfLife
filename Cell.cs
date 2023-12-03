namespace cyrae.GameOfLife
{
    public struct Cell 
    {
        public int columnIndex;
        public int rowIndex;

        public Cell(int columnIndex, int rowIndex)
        {
            this.columnIndex = columnIndex;
            this.rowIndex = rowIndex;
        }
    }
}