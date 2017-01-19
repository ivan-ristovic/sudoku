namespace sudoku
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.msMainMenuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuGameNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuGameNewCreatePuzzle = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuGameNewLoadFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msMainMenuGameCheckSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuGameSolve = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msMainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuField = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuFieldLock = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuFieldUnlock = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuFieldClear = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuRules = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLockedField = new System.Windows.Forms.Label();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuGame,
            this.msMainMenuField,
            this.msMainMenuHelp});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(309, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // msMainMenuGame
            // 
            this.msMainMenuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuGameNew,
            this.msMainMenuSeparator1,
            this.msMainMenuGameCheckSolution,
            this.msMainMenuGameSolve,
            this.msMainMenuSeparator2,
            this.msMainMenuExit});
            this.msMainMenuGame.Name = "msMainMenuGame";
            this.msMainMenuGame.Size = new System.Drawing.Size(50, 20);
            this.msMainMenuGame.Text = "Game";
            // 
            // msMainMenuGameNew
            // 
            this.msMainMenuGameNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuGameNewCreatePuzzle,
            this.msMainMenuGameNewLoadFromFile});
            this.msMainMenuGameNew.Name = "msMainMenuGameNew";
            this.msMainMenuGameNew.Size = new System.Drawing.Size(153, 22);
            this.msMainMenuGameNew.Text = "New";
            // 
            // msMainMenuGameNewCreatePuzzle
            // 
            this.msMainMenuGameNewCreatePuzzle.Name = "msMainMenuGameNewCreatePuzzle";
            this.msMainMenuGameNewCreatePuzzle.Size = new System.Drawing.Size(148, 22);
            this.msMainMenuGameNewCreatePuzzle.Text = "Create puzzle";
            this.msMainMenuGameNewCreatePuzzle.Click += new System.EventHandler(this.msMainMenuGameNewCreatePuzzle_Click);
            // 
            // msMainMenuGameNewLoadFromFile
            // 
            this.msMainMenuGameNewLoadFromFile.Name = "msMainMenuGameNewLoadFromFile";
            this.msMainMenuGameNewLoadFromFile.Size = new System.Drawing.Size(148, 22);
            this.msMainMenuGameNewLoadFromFile.Text = "Load from file";
            this.msMainMenuGameNewLoadFromFile.Click += new System.EventHandler(this.msMainMenuGameNewLoadFromFile_Click);
            // 
            // msMainMenuSeparator1
            // 
            this.msMainMenuSeparator1.Name = "msMainMenuSeparator1";
            this.msMainMenuSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // msMainMenuGameCheckSolution
            // 
            this.msMainMenuGameCheckSolution.Name = "msMainMenuGameCheckSolution";
            this.msMainMenuGameCheckSolution.Size = new System.Drawing.Size(153, 22);
            this.msMainMenuGameCheckSolution.Text = "Check solution";
            this.msMainMenuGameCheckSolution.Click += new System.EventHandler(this.msMainMenuGameCheckSolution_Click);
            // 
            // msMainMenuGameSolve
            // 
            this.msMainMenuGameSolve.Name = "msMainMenuGameSolve";
            this.msMainMenuGameSolve.Size = new System.Drawing.Size(153, 22);
            this.msMainMenuGameSolve.Text = "Solve";
            this.msMainMenuGameSolve.Click += new System.EventHandler(this.msMainMenuGameSolve_Click);
            // 
            // msMainMenuSeparator2
            // 
            this.msMainMenuSeparator2.Name = "msMainMenuSeparator2";
            this.msMainMenuSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // msMainMenuExit
            // 
            this.msMainMenuExit.Name = "msMainMenuExit";
            this.msMainMenuExit.Size = new System.Drawing.Size(153, 22);
            this.msMainMenuExit.Text = "Exit";
            this.msMainMenuExit.Click += new System.EventHandler(this.msMainMenuExit_Click);
            // 
            // msMainMenuField
            // 
            this.msMainMenuField.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuFieldLock,
            this.msMainMenuFieldUnlock,
            this.msMainMenuFieldClear});
            this.msMainMenuField.Name = "msMainMenuField";
            this.msMainMenuField.Size = new System.Drawing.Size(44, 20);
            this.msMainMenuField.Text = "Field";
            // 
            // msMainMenuFieldLock
            // 
            this.msMainMenuFieldLock.Name = "msMainMenuFieldLock";
            this.msMainMenuFieldLock.Size = new System.Drawing.Size(111, 22);
            this.msMainMenuFieldLock.Text = "Lock";
            this.msMainMenuFieldLock.Click += new System.EventHandler(this.msMainMenuFieldLock_Click);
            // 
            // msMainMenuFieldUnlock
            // 
            this.msMainMenuFieldUnlock.Enabled = false;
            this.msMainMenuFieldUnlock.Name = "msMainMenuFieldUnlock";
            this.msMainMenuFieldUnlock.Size = new System.Drawing.Size(111, 22);
            this.msMainMenuFieldUnlock.Text = "Unlock";
            this.msMainMenuFieldUnlock.Click += new System.EventHandler(this.msMainMenuFieldUnlock_Click);
            // 
            // msMainMenuFieldClear
            // 
            this.msMainMenuFieldClear.Name = "msMainMenuFieldClear";
            this.msMainMenuFieldClear.Size = new System.Drawing.Size(111, 22);
            this.msMainMenuFieldClear.Text = "Clear";
            this.msMainMenuFieldClear.Click += new System.EventHandler(this.msMainMenuFieldClear_Click);
            // 
            // msMainMenuHelp
            // 
            this.msMainMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenuRules,
            this.msMainMenuAbout});
            this.msMainMenuHelp.Name = "msMainMenuHelp";
            this.msMainMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.msMainMenuHelp.Text = "Help";
            // 
            // msMainMenuRules
            // 
            this.msMainMenuRules.Name = "msMainMenuRules";
            this.msMainMenuRules.Size = new System.Drawing.Size(152, 22);
            this.msMainMenuRules.Text = "Rules";
            this.msMainMenuRules.Click += new System.EventHandler(this.msMainMenuRules_Click);
            // 
            // msMainMenuAbout
            // 
            this.msMainMenuAbout.Name = "msMainMenuAbout";
            this.msMainMenuAbout.Size = new System.Drawing.Size(152, 22);
            this.msMainMenuAbout.Text = "About";
            this.msMainMenuAbout.Click += new System.EventHandler(this.msMainMenuAbout_Click);
            // 
            // lblLockedField
            // 
            this.lblLockedField.AutoSize = true;
            this.lblLockedField.BackColor = System.Drawing.Color.White;
            this.lblLockedField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockedField.Location = new System.Drawing.Point(289, -3);
            this.lblLockedField.Name = "lblLockedField";
            this.lblLockedField.Size = new System.Drawing.Size(20, 25);
            this.lblLockedField.TabIndex = 1;
            this.lblLockedField.Text = "⚷";
            this.lblLockedField.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 326);
            this.Controls.Add(this.lblLockedField);
            this.Controls.Add(this.msMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGame;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGameNew;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGameNewCreatePuzzle;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGameNewLoadFromFile;
        private System.Windows.Forms.ToolStripSeparator msMainMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGameCheckSolution;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuGameSolve;
        private System.Windows.Forms.ToolStripSeparator msMainMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuExit;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuRules;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuField;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuFieldLock;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuFieldUnlock;
        private System.Windows.Forms.Label lblLockedField;
        private System.Windows.Forms.ToolStripMenuItem msMainMenuFieldClear;
    }
}

