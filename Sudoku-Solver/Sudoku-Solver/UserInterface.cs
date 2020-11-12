using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku_Solver
{
    public class UserInterface
    {
        /// <summary>
        /// Simple start-up method.
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Hello! Welcome to Silly Sally's Sudoku Solver!");
            Console.WriteLine("(Sorry, I couldn't help myself...)");
            Console.WriteLine();
            Console.WriteLine("Please input the sudoku you wish to be solved, replacing blanks with 0s.");
            string userInput = Console.ReadLine();


        }

        /// <summary>
        /// Confirmation that what was input is correct.
        /// </summary>
        public bool Confirm(string sudoku)
        {
            BuildVisualSudoku(sudoku);

            Console.WriteLine("Is what you see correct?");

            return true;
        }

        /// <summary>
        /// Builds a visual representation of the sudoku.
        /// </summary>
        /// <param name="sudoku"></param>
        public void BuildVisualSudoku(string sudoku)
        {
            List<string> sudokuList = sudoku.Split(' ').ToList();


        }
    }
}
