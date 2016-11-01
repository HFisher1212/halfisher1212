using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9WalkThrough.java
{
    class CreditCardPayment : Payment
    {
        public string Name { get; set; }
        public long Number { get; set; }

        public CreditCardPayment() : base()
        {
            Name = "John Doe";
            Number = 123456789;
        }

        public CreditCardPayment(string name, long number) : this()
        {
            Name = name;
            Number = number;
        }

        public CreditCardPayment(string name, long number, double amount) : base(amount)
        {
            Name = name;
            Number = number;
        }

        public override void PaymentDetails()
        {
            Console.WriteLine("Credit Card Payment");
            Console.WriteLine(" Name: {0}, Number: {1}", Name, Number);
            base.PaymentDetails();
        }


    }
}
