namespace Question_8_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You want to input an array with how many elements??");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            //creating the array of size arrSize
            int[] inputArray = new int[arrSize];

            
            for(int i = 0; i<inputArray.Length; i++){
                Console.WriteLine("Enter the element at index " + i);
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Input array inserted");

            double ave = 0.0;
            int total = 0, count = inputArray.Length ;
            for(int i = 0; i < inputArray.Length; i++)
            {
                total+= inputArray[i];
            }
            ave =(double)total / count; // we did type casting of integers to double to allow decimal average values
            Console.WriteLine("The total is {0}, number of elements ={1} and the average is {2}",total,count,ave);
        }
    }
}


