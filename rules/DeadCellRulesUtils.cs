namespace GameOfLife.rules
{
	public static partial class RulesUtils
	{
		/// <summary>
		/// Get the next state of a currently dead cell. The next state depends
		/// on the passed number of living neighbor cells.
		/// </summary>
		/// <param name="numberOfLivingCells">This parameter represents the
		/// number of living neighbor cells.</param>
		/// <returns>Returns a char that represents the next state of the
		/// currently a dead cell.</returns>
		public static char GetNextStateOfDeadCell(int numberOfLivingCells)
		{
			if (numberOfLivingCells == 3)
				return 'O';
			else
				return 'X';
		}
	}
}

