namespace Practice_qn_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth Year");
            int birthYr = Convert.ToInt32(Console.ReadLine());
            int age = 2023 - birthYr;
            Console.WriteLine("You are {0} years old", age);
        }
    }
}

