
namespace RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();
            int rand = random.Next(1, 100);
            int guess = 0;
            bool equal = false;
            while (equal==false)
            {
                Console.WriteLine("Enter any number and lets see if it matches");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < rand)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else if(guess > rand){
                    Console.WriteLine("Your guess is too high");
                }

                if(guess == rand)
                {
                    Console.WriteLine("Yes you made a correct guess");
                    equal = true;

                }
            }
        }
    }
}

