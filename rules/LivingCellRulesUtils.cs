namespace GameOfLife.rules
{
	public static partial class RulesUtils
	{
        /// <summary>
		/// Get the next state of a currently alive cell. The next state depends
        /// on the passed number of living neighbor cells.
        /// </summary>
        /// <param name="numberOfLivingCells">This parameter represents the
        /// number of living neighbor cells.</param>
        /// <returns>Returns a char that represents the next state of the
        /// currently a alive cell.</returns>
        public static char GetNextStateOfLivingCell(int numberOfLivingCells)
		{
			if (numberOfLivingCells < 2 || numberOfLivingCells > 3)
				return 'X';
			else 
				return 'O';
		}
	}
}

