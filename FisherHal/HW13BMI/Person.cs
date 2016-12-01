using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13BMI
{
    class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }
        public int Height { set; get; }
        public int Weight { set; get; }

        public Person(string fname, string lname, int age, int height, int weight)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}, {2}, {3} in., {4} lbs.", FirstName, LastName, Age, Height, Weight);
        }
    }
}
