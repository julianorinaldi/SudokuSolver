using System;

namespace SudokuSolver
{
    public class SudokuValidator
    {
        public bool IsValid(string[][] valueStrings)
        {
            bool isValue = true;
            int length = valueStrings[0].Length;
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    var valueRowCol = valueStrings[row][col];
                    if (!string.IsNullOrWhiteSpace(valueRowCol))
                    {
                        var coord = new Coord(row, col, valueRowCol);
                        string[] rows = new string[length];
                        string[] cols = new string[length];
                        for (int i = 0; i < length; i++)
                        {
                            cols[i] = valueStrings[row][i];
                        }
                        
                        for (int i = 0; i < length; i++)
                        {
                            rows[i] = valueStrings[i][col];
                        }

                        isValue = FindNumberRowCol(coord, rows, cols);
                        if (!isValue)
                            return false;
                    }
                }
            }

            return true;
        }

        public bool FindNumberRowCol(Coord coord, string[] rowValues, string[] colValues)
        {
            for (int i = 0; i < rowValues.Length; i++)
            {
                if (i == coord.Row)
                    continue;

                if (coord.Value.Equals(rowValues[i]))
                    return false;

                if (i == coord.Col)
                    continue;

                if (coord.Value.Equals(colValues[i]))
                    return false;
            }

            return true;
        }
    }
}
