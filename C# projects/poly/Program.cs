namespace poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human nashe = new Human();
            nashe.greet();
            nashe.greet("Farai");
            nashe.sleep();

            Student nashe2;
            nashe2 = new Student();
            nashe2.greet();
            nashe2.sleep();

         
          

        }
    }
    class Human{
        public string name;
        public int age;
        /*
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        */
        //Method Overloading
        public void greet()
        {
            Console.WriteLine("Hello");
        }
        public void greet(string name) 
        {
            Console.WriteLine("Hello"+name);
        }
        public virtual void sleep()
        {
            Console.WriteLine("Sleeps for 12 hours");
        }
        /*
        public Human(int age) {
            this.name = "Farai";
            this.age = 20;
        }
        */
      
}
    class Student: Human
    {
        public override void sleep()
        {
            Console.WriteLine("Sleeps for 10 hours");
        }
    }
}