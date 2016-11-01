using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab.java
{
    class Document
    {
        public string Text { get; set; }

        public Document()
        {
            Text = "Blank document.";
        }

        public Document(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return " " + Text;
        }
    }
}
