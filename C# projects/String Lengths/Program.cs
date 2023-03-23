using System;
namespace String_Lengths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string and press enter");
            string string1 = (Console.ReadLine());
            Console.WriteLine("The string you entered have {0} letters",string1.Length);
        }
    }
}