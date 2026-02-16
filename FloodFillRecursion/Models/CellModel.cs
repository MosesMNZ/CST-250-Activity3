/*
 * Moses Muamba-Nzambi
 * CST - 250
 * 02/15/2026
 * Flood Fill Recursion
 * Activity 3
 */

namespace FloodFillRecursion.Models
{
    internal class CellModel
    {
        // Cell Model Properties
        public int Row { get; set; }
        public int Column { get; set; }
        public string Contents { get; set; }

        /// <summary>
        /// Parameterized constructor for CellModel
        /// </summary>
        public CellModel(int row, int column, string contents)
        {
            Row = row;
            Column = column;
            Contents = contents;
        }
    }
}
