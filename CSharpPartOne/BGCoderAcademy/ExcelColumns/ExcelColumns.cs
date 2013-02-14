using System;
using System.Numerics;

class ExcelColumns
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[10];
        for (int i = 1; i <= n; i++)
        {
            nums[n-i]=char.Parse(Console.ReadLine());
            nums[n-i] = nums[n-i] - '@';
        }
        BigInteger sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += (BigInteger)Math.Pow(26, i) * nums[i];
        }
        Console.WriteLine(sum);
    }
}

