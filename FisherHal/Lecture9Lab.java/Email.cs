using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab.java
{
    class Email : Document
    {
        public string Sender{ get; set; }
        public string Recipent { get; set; }
        public string Title{ get; set; }

        public Email() : base()
        {
            Sender = "NoName@Here.com";
            Recipent = "SomeWhereElse@NotHere.com";
            Title = "blank subject";
        }

        public Email(string sender, string recipent, string title, string text) : base(text)
        {
            Sender = sender;
            Recipent = recipent;
            Title = title;
        }

        public override string ToString()
        {
            return " " + Sender + " " + Recipent + " " + Title + " " + Text;
        }
    }
}
