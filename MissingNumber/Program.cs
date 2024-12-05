namespace MissingNumber;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 4, 3, 5, 2, 7, 9 };

        var missingNums = FinderMissingNumber.FindNumber(nums);
        
        foreach (var num in missingNums)
        {
            Console.WriteLine(num);
        }
    }
}
