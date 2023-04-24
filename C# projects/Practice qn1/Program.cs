namespace Practice_qn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine(); // this is not an error, its just a warning
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}, you are {1} years old.",name,age);
                    // OR YOU CAN DO IT LIKE THE STATEMENT BELOW
           // Console.WriteLine("Hello "+name+" you are "+age+" years old"); 

        }
    }
}
