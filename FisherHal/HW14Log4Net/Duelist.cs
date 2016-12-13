using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelDemo
{
    class Duelist
    {
        public string Name { set; get; }
        public bool IsAlive { set; get; }
        public double Accuracy { set; get; }
        private static Random rand = new Random();

        public Duelist(string name, double accuracy)
        {
            Name = name;
            IsAlive = true;
            Accuracy = accuracy;
        }

        public void ShootAtTarget(Duelist other)
        {
            double holder = rand.NextDouble();
            other.IsAlive = holder > this.Accuracy;
        }


        public bool Equals(Duelist other)
        {
            return this.Name == other.Name && this.IsAlive == other.IsAlive && this.Accuracy == other.Accuracy; 
        }
    }
}
