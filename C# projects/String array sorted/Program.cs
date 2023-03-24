using System.Globalization;

namespace String_array_sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            int a = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number string {0}", a++);
                names[i] = Console.ReadLine();
            }
           Array.Sort(names);
            Console.WriteLine("Ascending order: ");
            foreach(string value in names)
                Console.WriteLine(value);
        }
    }
}