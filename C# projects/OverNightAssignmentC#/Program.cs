namespace OverNightAssignmentC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object for Class1 (Overriden)
            Overriden overriden = new Overriden();
            overriden.memberVar1 = 6.1f;
            overriden.memberVar2 = 4f;
            // modulus method
            overriden.modulus();

        }
    }
}