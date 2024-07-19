
namespace MissingNumber;

public class FinderMissingNumber
{
    public static List<int> FindNumber(int[] nums) 
    {
        var maxValue = nums.Max();
        var minValue = nums.Min();
        var missingNums = new List<int>();

        for (int i = minValue; i < maxValue; i++)
        {
            if (!nums.Contains(i))
            {                 
                missingNums.Add(i);
            }
        }

        return missingNums;
    }
}
