using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    class SudokuGrid
    {
        private int GridSize;
        private int BoxSize;
        private int CellSize;
        private Label[,] Field;


        public SudokuGrid(int size, int cellSize, int startX, int startY, MainForm parent)
        {
            GridSize = size;
            CellSize = cellSize;
            Field = new Label[GridSize, GridSize];

            // Label creation locations
            int horizontal = startX;
            int vertical = startY;

            // Specifies after how many labels we make space
            BoxSize = size / (int)Math.Sqrt(size);

            // Generating field
            for (int i = 0; i < GridSize; i++) {

                // Space between small squares
                if (i % BoxSize == 0)
                    vertical += 1;

                // Positioning at begining of the row
                horizontal = startX;

                for (int j = 0; j < GridSize; j++) {

                    // Space between small squares
                    if (j % BoxSize == 0)
                        horizontal += 1;

                    // Creating new label
                    Field[i, j] = new Label()
                    {
                        Size = new Size(CellSize, CellSize),
                        Location = new Point(horizontal, vertical),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.White,
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

            if (GridHasNoConflicts(sender) == false)
                ((Label)sender).BackColor = Color.Tomato;
            else
                ((Label)sender).BackColor = Color.White;
        }

        private void OnLeftClick(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l.Text == "")
                l.Text = "1";
            else if (l.Text == GridSize.ToString())
                l.Text = "1";
            else
                l.Text = (int.Parse(l.Text) + 1).ToString();
        }

        private void OnRightClick(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l.Text == "")
                l.Text = GridSize.ToString();
            else if (l.Text == "1")
                l.Text = GridSize.ToString();
            else
                l.Text = (int.Parse(l.Text) - 1).ToString();
        }

        private void OnMiddleClick(object sender, EventArgs e)
        {
            ((Label)sender).Text = "";
        }

        private bool GridHasNoConflicts(object sender)
        {
            Label pressedLabel = sender as Label;
            
            // Getting indexes of our clicked cell
            GridLocation index = (GridLocation)pressedLabel.Tag;
            int x = index.i;
            int y = index.j;

            // Checking row
            for (int i = 0; i < GridSize; i++)
                if (i != y && Field[x, i].Text == pressedLabel.Text)
                    return false;

            // Checking column
            for (int i = 0; i < GridSize; i++)
                if (i != x && Field[i, y].Text == pressedLabel.Text)
                    return false;

            // Checking square
            int sqStartX = x - x % BoxSize;
            int sqEndX = sqStartX + BoxSize;
            int sqStartY = y - y % BoxSize;
            int sqEndY = sqStartY + BoxSize;
            for (int i = sqStartX; i < sqEndX; i++)
                for (int j = sqStartY; j < sqEndY; j++)
                    if (i != x && j != y && Field[i, j].Text == pressedLabel.Text)
                        return false;

            return true;
        }

        public void Solve()
        {
            // TODO
        }

        public void LoadPuzzle(String[] content)
        {

            // For now only supported puzzles to load are 9x9

            try {
                for (int i = 0; i < GridSize; i++) {
                    char[] line = content[i].ToCharArray();
                    for (int j = 0; j < GridSize; j++) {
                        if (Char.IsNumber(line[j]) == false)
                            throw new Exception();
                        Field[i, j].Text = (line[j] == '0') ? "" : (line[j] - '0').ToString();
                    }
                }
            } catch (Exception) {
                MessageBox.Show("Invalid file content!");
            }
        }
    }
}
