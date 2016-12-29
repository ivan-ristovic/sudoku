using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    class Grid
    {
        private int Size = 9;
        private int CellSize = 30;
        private Label[,] Field;


        public Grid(int size, int cellSize, int startX, int startY, MainForm parent)
        {
            Size = size;
            Field = new Label[Size, Size];

            // Generating field
            int horizontal = startX;
            int vertical = startY;

            for (int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {

                    // Creating new label
                    Field[i, j] = new Label()
                    {
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(horizontal, vertical),
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Tag = new GridLocation(i, j)
                    };

                    // Adding click event
                    Field[i, j].Click += OnFieldClick;

                    // Adding control to parent form
                    parent.Controls.Add(Field[i, j]);

                    // Moving to next column to draw another button
                    horizontal += cellSize;
                }

                // Moving to next row
                horizontal = startX;
                vertical += cellSize;
            }
        }


        // Helper class, whose instances will hold indexes of corresponding label in Field array
        internal class GridLocation
        {
            public readonly int i;
            public readonly int j;

            public GridLocation(int i, int j)
            {
                this.i = i;
                this.j = j;
            }
        }


        private void OnFieldClick(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
