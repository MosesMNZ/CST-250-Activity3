/*
 * Moses Muamba-Nzambi
 * CST - 250
 * 02/15/2026
 * Flood Fill Recursion
 * Activity 3
 */

using System;

namespace FloodFillRecursion.Models
{
    internal class BoardModel
    {
        // BoardModel Properties
        public int Size { get; set; }
        public CellModel[,] Grid { get; set; }
        public int NumShapes { get; set; }

        /// <summary>
        /// Parameterized constructor for BoardModel
        /// </summary>
        public BoardModel(int size, int numShapes)
        {
            Size = size;
            NumShapes = numShapes;
            Grid = new CellModel[Size, Size];

            // Set up the Grid
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Grid[row, col] = new CellModel(row, col, "E");
                }
            }

            // Place random shapes on the board
            PlaceShapes();
        }

        /// <summary>
        /// Create shapes to place on the board
        /// </summary>
        public void PlaceShapes()
        {
            Random random = new Random();
            int shapeSize = Size / 2, row = 0, col = 0;

            for (int shapes = 0; shapes < NumShapes; shapes++)
            {
                row = random.Next(0, Size - shapeSize + 1);
                col = random.Next(0, Size - shapeSize + 1);

                for (int offset = 0; offset < shapeSize; offset++)
                {
                    // Top Wall
                    Grid[row, col + offset].Contents = "W";

                    // Bottom Wall
                    Grid[row + shapeSize - 1, col + offset].Contents = "W";

                    // Left Wall
                    Grid[row + offset, col].Contents = "W";

                    // Right Wall
                    Grid[row + offset, col + shapeSize - 1].Contents = "W";
                }
            }
        }
    }
}
