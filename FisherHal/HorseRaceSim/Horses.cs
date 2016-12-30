using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceSim
{
    class Horses : IComparable<Horses>
    {
        public string Name { set; get; }
        public int Endurance { set; get; }
        public int Speed { set; get; }
        public int Rank { set; get; }
        public int Odds { set; get; }

        public Horses(string name, int endurance, int speed, int rank, int odds)
        {
            Name = name;
            Endurance = endurance;
            Speed = speed;
            Rank = rank;
            Odds = odds;
        }


        

        public int CompareTo(Horses other)
        {
            if (this.Rank < other.Rank)
            {
                return 1;
            }
            else if (this.Rank > other.Rank)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool equals(string otherName)
        {
            return Name.Equals(otherName);
        }
    }
}
