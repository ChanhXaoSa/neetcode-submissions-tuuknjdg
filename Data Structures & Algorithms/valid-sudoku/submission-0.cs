public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i < 9; i++)
        {
            if (!IsValidRow(board, i) || !IsValidColumn(board, i) || !IsValidBox(board, (i / 3) * 3, (i % 3) * 3))
            {
                return false;
            }
        }
        return true;
    }

    public bool IsValidRow(char[][] board, int row)
    {
        HashSet<char> seen = new HashSet<char>();
        for (int col = 0; col < 9; col++)
        {
            char current = board[row][col];
            if (current != '.')
            {
                if (seen.Contains(current))
                {
                    return false;
                }
                seen.Add(current);
            }
        }
        return true;
    }

    public bool IsValidColumn(char[][] board, int col)
    {
        HashSet<char> seen = new HashSet<char>();
        for (int row = 0; row < 9; row++)
        {
            char current = board[row][col];
            if (current != '.')
            {
                if (seen.Contains(current))
                {
                    return false;
                }
                seen.Add(current);
            }
        }
        return true;
    }

    public bool IsValidBox(char[][] board, int startRow, int startCol)
    {
        HashSet<char> seen = new HashSet<char>();
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                char current = board[startRow + row][startCol + col];
                if (current != '.')
                {
                    if (seen.Contains(current))
                    {
                        return false;
                    }
                    seen.Add(current);
                }
            }
        }
        return true;
    }
}
