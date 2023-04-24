using System.Transactions;
namespace C__Practice_qn_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];
            Console.WriteLine("\t Enter the integer array elements for the First array");
            int maxIndex = 5;
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("Enter Element on index " + i);
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Filling the second array
            Console.WriteLine();
            Console.WriteLine("\t Enter the integer array elements for the Second Array");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine("Enter Element on index " + i);
                secondArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Displaying the first array
            Console.Write("First Array elements are : \t");
            for (int i = 0; i < firstArray.Length; i++) {
                Console.Write(firstArray[i] + ", ");
            }
            Console.WriteLine();
            // Displaying the Second array
            Console.Write("Second Array elements are : \t");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            // Perfoming the addition now 
            for (int i =0; i < firstArray.Length; i++)
            {
                firstArray[i]+= secondArray[i];
            }
            Console.Write("\t \t The RESULTING Array is : ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i]+",");
            }
        }
    }
}
