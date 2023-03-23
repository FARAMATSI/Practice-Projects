using System;
namespace Random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int num;
            Random rand = new Random();
            while (a == 0)
            {
                double d = rand.Next(1, 100);
                Console.WriteLine("enter any number");
                num = Convert.ToInt32(Console.ReadLine());
                if (d == num)
                {
                    Console.WriteLine("Yes the number you entered matches with {0}",d);
                    a++;
                }
            }
            
        }
    }
}