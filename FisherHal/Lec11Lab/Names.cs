/******************************************************************
 * @author      Hal Fisher
 * @class       CS155
 * @project     lec11lab
 * @date        11.21.2016
 * ****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec11Lab
{
    class Names
    {
        // GETTER AND SETTER METHODS
        public int Rank { set; get; }
        public int Count { set; get; }

        // DEFAULT CONSTRUCTOR
        public Names()
        {
            Rank = 0;
            Count = 0;
        }

        // FULL CONSTRUCTOR
        public Names(int rank, int count)
        {
            Rank = rank;
            Count = count;
        }

        // TOSTRING METHOD
        public override string ToString()
        {
            return "\n Count: " + Count + "\n Rank: " + Rank; 
        }

        // EQUALS METHOD
        public bool Equals(Names other)
        {
            return (this.Rank == other.Rank && this.Count == other.Count);
        }
    }
}
