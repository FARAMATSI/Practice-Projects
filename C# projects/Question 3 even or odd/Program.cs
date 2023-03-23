using System;
namespace Question_3_even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int a = Convert.ToInt32(Console.ReadLine());
            string s = (a % 2 == 0) ? "Number is even" : "Number is odd";
            Console.WriteLine(s);
        }
    }
}