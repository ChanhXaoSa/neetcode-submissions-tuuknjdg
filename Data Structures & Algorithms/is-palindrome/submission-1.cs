public class Solution
{
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();
        for (int i = 0; i < s.Length; i++)
        {
            if (!char.IsLetterOrDigit(s[i]))
            {
                s = s.Remove(i, 1);
                i--;
            }
        }
        string reverse = new string(s.Reverse().ToArray());
        return s.Equals(reverse);
    }
}
