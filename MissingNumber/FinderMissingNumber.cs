
namespace MissingNumber;

public class FinderMissingNumber
{
    public static int FindNumber(int[] nums) 
    {
        int maxValue = nums.Max();
        int minValue = nums.Min();

        for (int i = minValue; i < maxValue; i++)
        {
            if (!nums.Contains(i))
            {
                return i;
            }
        }

        return 0;
    }
}
