using System;
namespace _3_nums_comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            int i = 0;
            int b = 1;
            for(i=0; i<=2; i++)
            {
                Console.WriteLine("Enter number {0}", b++);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            if ((nums[0] > nums[1]) && (nums[0] > nums[2]))
            { 
                Console.WriteLine("The greatest number is {0}", nums[0]);
            }
           else if ((nums[1] > nums[0]) && (nums[1] > nums[2]))
            {
                Console.WriteLine("The greatest number is {0}", nums[1]);
            }
           else if ((nums[2] > nums[0]) && (nums[2] > nums[1]))
            {
                Console.WriteLine("The greatest number is {0}", nums[2]);
            }

        }
    }
}