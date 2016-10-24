using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7Proj2TempetureConverter
{
    class Temperature
    {
        // CLASS VARIABLES

        private float temp;
        private char type;

        // DEFAULT CONSTRUCTOR
        public Temperature()
        {
            setTemp(0);
            setType('C');
        }

        // TEMP CONSTRUCTOR
        public Temperature(float temp)
        {
            setTemp(temp);
            setType('C');
        }

        // TYPE CONSTRUCTOR
        public Temperature(char type)
        {
            setTemp(0);
            setType(type);
        }

        // FULL CONSTRUCTOR
        public Temperature(float temp, char type)
        {
            setTemp(temp);
            setType(type);
        }

        // SETTERS

        // SET TEMP
        public void setTemp(float num)
        {
            temp = num;
        }

        // SET TYPE
        public void setType(char gauge)
        {
            type = gauge;
        }

        // SET ALL 
        public void setAll(float num, char gauge)
        {
            temp = num;
            type = gauge;
        }

        // GETTERS

        // GET TEMP
        public float getTemp()
        {
            return temp;
        }

        // GET TYPE
        public char getType()
        {
            return type;
        }

        // OTHER METHODS

        // GET CELCIUS
        public float getCelcius(float num, char type)
        {
            if (type == 'F')
            {
                return (float)((num - 32) / 1.8);
            }
            return num;
        }

        // GET FAHRENHEIT
        public float getFahrenheit(float num, char type)
        {
            if (type == 'C')
            {
                return (float)((num * 1.8) + 32);
            }
            return num;
        }

        // TOSTRING
        public override string ToString()
        {
            return " Temperature: " + getTemp() + " " + getType();
        }

        // EQUALS
        public bool Equals(Temperature other)
        {
            return this.getTemp() == other.getTemp() && this.getType() == other.getType();
        }
    }
}
