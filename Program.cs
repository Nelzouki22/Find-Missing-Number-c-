using System;

class Program
{
    static int FindMissingNumber(int[] nums)
    {
        int n = nums.Length;
        int total = (n + 1) * (n + 2) / 2; // Sum of first n+1 natural numbers

        for (int i = 0; i < n; i++)
        {
            total -= nums[i];
        }

        return total;
    }

    static void Main()
    {
        int[] nums = { 1, 2, 4, 5, 6 }; // مثال على مصفوفة بها رقم مفقود
        int missingNumber = FindMissingNumber(nums);

        Console.WriteLine("The missing number is: " + missingNumber);
    }
}
