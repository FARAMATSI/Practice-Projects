using System;
namespace Age_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year");
            int yr = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Yiu are {0} years old", 2023-yr);
        }
    }
}