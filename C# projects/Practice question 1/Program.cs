namespace Practice_question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age");s
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + " You are " + age + " years old.");
        }
    }
}