using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverNightAssignmentC_
{
    internal class Overriden
    {
        public double memberVar1;
        public double memberVar2;
        public virtual void modulus()
        {
            double result = (this.memberVar1 % this.memberVar2);
            Console.WriteLine("The modulus is " + result);
        }
    }
}
