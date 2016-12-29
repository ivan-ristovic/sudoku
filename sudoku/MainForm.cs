using System;
using System.Windows.Forms;

namespace sudoku
{
    public partial class MainForm : Form
    {
        private const int CELL_SIZE = 30;
        private const int GRID_SIZE = 9;

        Grid MainGrid;


        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            MainGrid = new Grid(GRID_SIZE, CELL_SIZE, 20, 40, this);
        }

    }
}
