namespace Practice_Question_3._two_nums_difference_sum_and_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" The result of addition is {0} \n" +
                " The result of subtraction is {1}\n" +
                " The product of {2} and {3} is {4}\n" +
                " The quotient of {2} and {3} is {5}",a+b,a-b,a,b,a*b,a/b);
        }
    }
}