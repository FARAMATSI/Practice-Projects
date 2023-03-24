namespace Practice_Question_7_arrayint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 1;
           // double ave;
            int sum = 0;
            int[] nums = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the number on position {0}",position++);
                nums[i] = Convert.ToInt32(Console.ReadLine());
                sum += nums[i];
            }
            Console.WriteLine("The sum is {0} and average is {1}",sum,sum/10);
            
        }
    }
}