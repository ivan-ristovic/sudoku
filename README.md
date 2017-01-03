# :sparkles: 9x9 Sudoku Solver :sparkles:
![ss](https://raw.githubusercontent.com/IvanRistovic/sudoku/master/screenshots/2017-01-03.PNG)

## :page_facing_up: Description
Click **[here](https://en.wikipedia.org/wiki/Sudoku)** for more information about Sudoku and the rules.

This is a 9x9 (for now) Sudoku solver.
Coded in C# using Visual Studio 2017.

## :computer: Installation
For now, the only way to install and run the program is to clone the project locally and then import it into Visual Studio.
When the project is finished, I will add an installer and a precompiled executable as a release.

## :video_game: Usage
You can load whatever puzzle you want. There are two ways to do so:
- Manually entering numbers, and then solving the puzzle (not reccomended as I have not yet added validation checks)
- By creating your own ```.txt``` file. You can check ```puzzles/puzzle1.txt``` and see what format is required. You can then load the file using ```Game -> New -> Load from file```

Left click increments the value in the clicked cell.
Right click decrements the value in the clicked cell.
Middle click deletes the value in the clicked cell.

## :bug: Known bugs
None noticed so far.
