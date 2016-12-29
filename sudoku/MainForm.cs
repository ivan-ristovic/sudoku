using System;
using System.Windows.Forms;

namespace sudoku
{
    public partial class MainForm : Form
    {
        Grid MainGrid;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            MainGrid = new Grid(9, 30, 10, 10, this);
        }
    }
}
