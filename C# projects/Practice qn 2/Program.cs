namespace Practice_qn_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is {0} \nThe difference is {1} \nThe product is {2} \nThe quotient is {3}", num1+num2, num1-num2, num1 * num2, num1 / num2);
        }
    }
}