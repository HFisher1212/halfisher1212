using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9WalkThrough.java
{
    
    class Payment
    {
        public double Amount { get; set; }

        public Payment()
        {
            Amount = 0;
        }

        public Payment( double amount)
        {
            Amount = amount;
        }

        public virtual void PaymentDetails() // allows method to be overriden
        {
            Console.WriteLine(" Amount of Payment is: {0:C}", Amount);
        }


    }
}
