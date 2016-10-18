using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec7Demo
{
    public enum Size { Small, Medium, Large};
    

    public class Pizza
    {
        public const int TOPPING_COST = 2;
        private Size size;
        private int cheese;
        private int ham;
        private int pepperoni;

        public Pizza()
        {
            size = Size.Small;
            cheese = 1;
            ham = 0;
            pepperoni = 0;

        }

        public Pizza(Size size, int cheese, int pepperoni, int ham)
        {
            this.size = size;
            this.cheese = cheese;
            this.pepperoni = pepperoni;
            this.ham = ham;
        }

        public Size GetSize()
        {
            return this.size;
        }

        public int GetCheese()
        {
            return this.cheese;
        }

        public int GetHam()
        {
            return this.ham;
        }

        public int GetPepperoni()
        {
            return this.pepperoni;
        }

        public void SetCheese(int cheese)
        {
            if(cheese >=0)
            {
                this.cheese = cheese;
            }
        }

        public void SetHam(int ham)
        {
            if (ham >= 0)
            {
                this.ham = ham;
            }
        }

        public void SetPepperoni(int pepperoni)
        {
            if (pepperoni >= 0)
            {
                this.pepperoni = pepperoni;
            }
        }

        public double CalculateCost()
        {
            double price = 0.0;
            price = 2 * (GetHam() + GetCheese() + GetPepperoni());
            if (size.Equals("Small"))
            {
                price += 10;
            }
            if (size.Equals("Medium"))
            {
                price += 12;
            }
            if (size.Equals("Large"))
            {
                price += 14;
            }

            return price;
        }

        public override string ToString()
        {
            return String.Format(" Pizza [size: {0}, cheese: {1}, ham: {2}, pepperoni: {3}, price: $ {4}", GetSize(), GetCheese(), GetHam(), GetPepperoni(), CalculateCost());
        }


    }
}
