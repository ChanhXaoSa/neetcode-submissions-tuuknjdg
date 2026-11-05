public class Solution
{

    public string Encode(IList<string> strs)
    {
        var encoded = new StringBuilder();

        foreach (string str in strs)
        {
            encoded.Append(str.Length)
                   .Append('#')
                   .Append(str);
        }

        return encoded.ToString();
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            while (s[j] != '#')
            {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            int start = j + 1;
            string str = s.Substring(start, length);

            result.Add(str);
            i = start + length;
        }

        return result;
    }
}