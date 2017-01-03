using System;
using System.Windows.Forms;

namespace sudoku
{
    public partial class MainForm : Form
    {
        private const int CELL_SIZE = 30;
        private const int GRID_SIZE = 9;

        SudokuGrid MainGrid;


        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            MainGrid = new SudokuGrid(GRID_SIZE, CELL_SIZE, 20, 40, this);
        }

        // Game -> New -> Load from file
        private void msMainMenuGameNewLoadFromFile_Click(object sender, EventArgs e)
        {
            // Creating new FileDialog which will handle file opening
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Title = "Open Text File",
                Filter = "TXT files|*.txt",
                RestoreDirectory = true
            };

            // If user clicked OK
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // Reading selected file
                    String[] lines = System.IO.File.ReadAllLines(fileDialog.FileName);
                    // Loading puzzle
                    MainGrid.LoadPuzzle(lines);
                } catch (Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
