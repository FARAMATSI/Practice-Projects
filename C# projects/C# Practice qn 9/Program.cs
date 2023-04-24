using System;
namespace C__Practice_qn_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Strings do you want to add");
            int maxIndex = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[maxIndex];
            
            for(int i = 0; i< maxIndex; i++) {
                Console.WriteLine("Enter the value of the string on index " + i);
                stringArray[i] = Console.ReadLine();
            }

            string[] sorted = stringArray.OrderBy(o => o).ToArray();

            Console.WriteLine("The sorted Array is as follows: ");

            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i]+ ", ");
            }
            

        }
    }
}


