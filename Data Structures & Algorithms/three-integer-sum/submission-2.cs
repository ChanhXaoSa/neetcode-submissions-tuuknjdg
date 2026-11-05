public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        var result = new List<List<int>>();
        int i = 0;

        while (i < nums.Length - 2)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                i++;
                continue;
            }

            if (nums[i] > 0)
            {
                break;
            }

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                long sum = (long)nums[i] + nums[left] + nums[right];

                if (sum < 0)
                {
                    left++;
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    result.Add(new List<int>
                    {
                        nums[i], nums[left], nums[right]
                    });

                    left++;
                    right--;

                    while (left < right &&
                           nums[left] == nums[left - 1])
                    {
                        left++;
                    }

                    while (left < right &&
                           nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                }
            }

            i++;
        }

        return result;
    }
}