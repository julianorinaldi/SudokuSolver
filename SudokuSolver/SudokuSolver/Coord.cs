using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public class Coord
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Value { get; set; }

        public Coord(int row, int col, string value)
        {
            Row = row;
            Col = col;
            Value = value;
        }
    }
}
