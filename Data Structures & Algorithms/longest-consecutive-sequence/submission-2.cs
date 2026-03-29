public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var list = nums.OrderBy(x => x).ToArray();

        int longest = 1;
        int current = 1;

        int i = 0;
        int j = 1;

        while (j < list.Length)
        {
            if (list[j] == list[i])
            {
                j++;
                continue;
            }

            if (list[j] == list[i] + 1)
            {
                current++;
            }
            else
            {
                longest = Math.Max(longest, current);
                current = 1;
            }

            i = j;
            j++;
        }

        return Math.Max(longest, current);
    }
}