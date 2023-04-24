namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Dog
    {
        string name;
        public void getName()
        {
            name = "Farai";
        }
        void bark() {
            System.Console.WriteLine("Barks");
        }
    }
     class germanShepherd: Dog
    {
        //abstract void (string text);
        void bark()
        {
            System.Console.WriteLine("Barks too loud");
        }
    }
}