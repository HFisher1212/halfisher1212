using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Transmission
    {
        /** CLASS VARIABLES
         */

        private String name;
        private String type;
        private double firstGear;
        private double secondGear;
        private double thirdGear;
        private double fourthGear;
        private double fifthGear;
        private double overdrive;

        public Transmission()
        {
            name = " ";
            type = " ";
            firstGear = 0;
            secondGear = 0;
            thirdGear = 0;
            fourthGear = 0;
            fifthGear = 0;
            overdrive = 0;
        }

        public Transmission(String name, String type, double first, double second, double third, double fourth, double fifth, double overdrive)
        {
            setName(name);
            setType(type);
            setFirstGear(first);
            setSecondGear(second);
            setThirdGear(third);
            setFourthGear(fourth);
            setFifthGear(fifth);
            setOverdrive(overdrive); 
        }

        public Transmission(String name, String type, double first, double second, double third)
        {
            setName(name);
            setType(type);
            setFirstGear(first);
            setSecondGear(second);
            setThirdGear(third);
        }

        public Transmission(String name, String type, double first, double second, double third, double fourth, double overdrive)
        {
            setName(name);
            setType(type);
            setFirstGear(first);
            setSecondGear(second);
            setThirdGear(third);
            setFourthGear(fourth);
            setOverdrive(overdrive);
        }

        /** SETTERS
         */
        public void setName(String name)
        {
            this.name = name;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public void setFirstGear(double first)
        {
            this.firstGear = first;
        }

        public void setSecondGear(double second)
        {
            this.secondGear = second;
        }

        public void setThirdGear(double third)
        {
            this.thirdGear = third;
        }

        public void setFourthGear(double fourth)
        {
          this.fourthGear = fourth;
        }

        public void setFifthGear(double fifth)
        {
            this.fifthGear = fifth;
        }

        public void setOverdrive(double overdrive)
        {
            this.overdrive = overdrive;
        }

        /** GETTERS
         */
         
         public String getName()
        {
            return this.name;
        } 

        public String getType()
        {
            return this.type;
        }

        public double getFirstGear()
        {
            return this.firstGear;
        }

        public double getSecondGear()
        {
            return this.secondGear;
        }

        public double getThirdGear()
        {
            return this.thirdGear;
        }

        public double getFourthGear()
        {
            return this.fourthGear;
        }

        public double getFifthGear()
        {
            return this.fifthGear;
        }

        public double getOverdrive()
        {
            return this.overdrive;
        }

        // TOSTRING
        public override String ToString()
        {
            return " Transmission Name: " + getName() +
                " Type: " + getType() + " First Gear: " + this.getFirstGear() +
                " Second Gear: " + getSecondGear() + " Third Gear: " + getThirdGear() +
                " Fourth Gear: " + getFourthGear() + " Fifth Gear: " + getFifthGear() +
                " Overdrive: " + getOverdrive();
        }

        // EQUALS
        // 
        public bool Equals (Transmission other)
        {
            return this.getName() == other.getName();
        }
    }
}
