namespace Inlass_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a=3;
            int b=4;
            int c = 7; //we are declaring a variable
            /*
            Console.WriteLine("This is a multi line comment");
            Console.WriteLine("This is a multi line comment");
            */
            Console.WriteLine("the answer of adding {0} and {1} is {2}", a, b, a + b);
            Console.WriteLine("the product of multiplying {0} and {1} is {2}", a, b, a * b);
            Console.WriteLine("the new value of b is {0}", b=a);
            Console.WriteLine("the value of 3 cubed is {0} ",3*3*3);
           // the difference between unary and binary operater is that unary operater perfoms an action with a single operand eg -a while binary perfoms action with two operands eg a%b 
           string d =(a>b) ? "a is greater" : "a is not greater";
            Console.WriteLine(d);
            // ==represent general comparison 
            // === represent strict comparison
            if((a>b) && (a>c)){
                Console.WriteLine("a is the greatest");
            }
            // the syntax of using null-coalescing operator is a ?? b

*\
        }
    }
}