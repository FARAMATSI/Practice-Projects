namespace maams_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());// the user is going to enter a number but will be captured as string, meaning to say we have to change the input from string to integer. so we have to convert the string to integer

            Console.WriteLine("Enter operation (+,-,*,/): ");
            operation = Convert.ToChar(Console.ReadLine());// the input from user is automatically a string and we have to convert it from string to char. But the Convert command was not copltee and we'll complete it

            switch (operation)
            {
                case '+':
                    Console.WriteLine(num1 + "" + num2 + " = " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;
                case '/':
                    if (num2 == 0)
                        Console.WriteLine("Cannot divide by zero");
                    else
                        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;


                    Console.ReadKey();// this one is not an error it is just a warning and the code will run except for it being present                                                     
            }
        }
    } // an extra curly bracket is missing, to close the namespace declaration statement's block
}