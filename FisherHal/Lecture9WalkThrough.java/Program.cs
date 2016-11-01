using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9WalkThrough.java
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment credit = new CreditCardPayment("Hal Fisher", 23456789, 50);
            credit.PaymentDetails();
            Console.ReadLine();
           
        }
    }
}
