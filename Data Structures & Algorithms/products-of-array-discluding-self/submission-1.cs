public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int prod = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    prod *= nums[j];
                }
            }
            dict[i] = prod;
        }
        return dict.Values.ToArray();
    }
}
