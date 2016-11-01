using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab.java
{
    class File : Document
    {
        public string PathName{ get; set;}

        public File() : base()
        {
            PathName = "NoPath";
        }

        public File(string path, string text) : base(text)
        {
            PathName = path;
        }

        public override string ToString()
        {
            return " " + PathName + " " + base.ToString();
        }
    }
}
