using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{
    class Grid
    {
        private int Size = 9;
        private int CellSize = 30;
        private Button[,] Field;


        public Grid(int size, int cellSize, int startX, int startY, MainForm parent)
        {
            Size = size;
            Field = new Button[Size, Size];

            // Generating field
            int horizontal = startX;
            int vertical = startY;

            for (int i = 0; i < Size; i++) {
                for (int j = 0; j < Size; j++) {

                    // Creating new button
                    Field[i, j] = new Button()
                    {
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(horizontal, vertical)
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

        private void OnFieldClick(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
