namespace Practice_qn6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num3 = Convert.ToInt32(Console.ReadLine()); 

            int largest = 0;

            if ((num1 > num2) && (num1>num3))
            {
                largest = num1;
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                largest = num2;
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                largest = num3;
            }
            Console.WriteLine("The largest number among {0}, {1} and {2} is {3}",num1,num2,num3,largest);
        }
    }
}

