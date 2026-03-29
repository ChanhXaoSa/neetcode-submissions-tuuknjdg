public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            dict[i] = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    dict[i] *= nums[j];
                }
            }
        }
        return dict.Values.ToArray();
    }
}
