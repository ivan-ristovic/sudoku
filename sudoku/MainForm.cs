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

        // Game -> New -> Create puzzle
        private void msMainMenuGameNewCreatePuzzle_Click(object sender, EventArgs e)
        {
            MainGrid.ClearField();
            msMainMenuFieldUnlock.PerformClick();
        }

        // Game -> New -> Load from file
        private void msMainMenuGameNewLoadFromFile_Click(object sender, EventArgs e)
        {
            // Clearing current field and unlocking
            MainGrid.ClearField();
            msMainMenuFieldUnlock.PerformClick();

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

            msMainMenuFieldLock.PerformClick();
        }

        // Game -> Check Solution
        private void msMainMenuGameCheckSolution_Click(object sender, EventArgs e)
        {
            // TODO check if grid is filled completely

            if (MainGrid.HasNoConflicts())
                MessageBox.Show("No conflicts in the grid!", "Information");
            else
                MessageBox.Show("There are conflicts in the grid!", "Information");
        }

        // Game -> Solve
        private void msMainMenuGameSolve_Click(object sender, EventArgs e)
        {
            MainGrid.Solve();
        }

        // Game -> Exit
        private void msMainMenuExit_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        // Field -> Lock
        private void msMainMenuFieldLock_Click(object sender, EventArgs e)
        {
            if (MainGrid.HasNoConflicts() == false) {
                MessageBox.Show("Your grid has conflicts and therefore cannot be locked!", "Error");
                return;
            }

            MainGrid.LockField();
            lblLockedField.Visible = true;
            msMainMenuFieldLock.Enabled = false;
            msMainMenuFieldUnlock.Enabled = true;
        }

        // Field -> Unlock
        private void msMainMenuFieldUnlock_Click(object sender, EventArgs e)
        {
            MainGrid.UnlockField();
            lblLockedField.Visible = false;
            msMainMenuFieldLock.Enabled = true;
            msMainMenuFieldUnlock.Enabled = false;
        }

        // Field -> Clear
        private void msMainMenuFieldClear_Click(object sender, EventArgs e)
        {
            MainGrid.ClearField();
        }

        // Help -> Rules
        private void msMainMenuRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The classic Sudoku game involves a grid of 81 squares. The grid is divided into nine blocks, each containing nine squares.\n\nThe rules of the game are simple: each of the nine blocks has to contain all the numbers 1 - 9 within its squares.Each number can only appear once in a row, column or box.\n\nThe difficulty lies in that each vertical nine - square column, or horizontal nine - square line across, within the larger square, must also contain the numbers 1 - 9, without repetition or omission.", "Rules");
        }

        // Help -> About
        private void msMainMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a 9x9 (for now) Sudoku solver. Coded in C# using Visual Studio 2017.\n\nYou can load whatever puzzle you want. There are two ways to do so:\n\n1. Manually entering numbers, and then solving the puzzle (not reccomended as I have not yet added validation checks)\n2. By creating your own.txt file.You can check puzzles / puzzle1.txt and see what format is required.You can then load the file using Game->New->Load from file\n\nLeft click increments the value in the clicked cell. Right click decrements the value in the clicked cell.Middle click deletes the value in the clicked cell.", "About");
        }
    }
}
