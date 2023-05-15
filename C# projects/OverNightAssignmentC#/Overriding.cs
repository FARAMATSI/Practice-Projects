using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverNightAssignmentC_
{
    internal class Overriding: Overriden
    {
        public override void modulus()
        {
            double result = this.memberVar1 % this.memberVar2;
            Console.WriteLine("The modulus of {0} and {1} is {2}", this.memberVar1, this.memberVar2, result);
        }
    }
}
