namespace LoopsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 6; i >=2; i-=2)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }
    }
}