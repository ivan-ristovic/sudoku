using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    class SudokuGrid
    {
        private int Size = 9;
        private int CellSize;
        private Label[,] Field;


        public SudokuGrid(int size, int cellSize, int startX, int startY, MainForm parent)
        {
            Size = size;
            CellSize = cellSize;
            Field = new Label[Size, Size];

            // Label creation locations
            int horizontal = startX;
            int vertical = startY;

            // Specifies after how many labels we make space
            int spaceIndex = size / (int)Math.Sqrt(size);

            // Generating field
            for (int i = 0; i < Size; i++) {

                // Space between small squares
                if (i % spaceIndex == 0)
                    vertical += 1;

                // Positioning at begining of the row
                horizontal = startX;

                for (int j = 0; j < Size; j++) {

                    // Space between small squares
                    if (j % spaceIndex == 0)
                        horizontal += 1;

                    // Creating new label
                    Field[i, j] = new Label()
                    {
                        Size = new Size(CellSize, CellSize),
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
                    horizontal += cellSize - 1;
                }

                // Moving to next row
                vertical += cellSize - 1;
            }

            // Resizing parent form to fit the new size
            parent.Size = new Size(horizontal + 2 * startX, vertical + startY + CellSize / 2);
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
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
                OnLeftClick(sender, e);
            else if (me.Button == MouseButtons.Right)
                OnRightClick(sender, e);
            else if (me.Button == MouseButtons.Middle)
                OnMiddleClick(sender, e);
            else return;
        }

        private void OnLeftClick(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l.Text == "")
                l.Text = "1";
            else if (l.Text == "9")
                l.Text = "1";
            else
                l.Text = (int.Parse(l.Text) + 1).ToString();
        }

        private void OnRightClick(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l.Text == "")
                l.Text = "9";
            else if (l.Text == "1")
                l.Text = "9";
            else
                l.Text = (int.Parse(l.Text) - 1).ToString();
        }

        private void OnMiddleClick(object sender, EventArgs e)
        {
            ((Label)sender).Text = "";
        }
    }
}
