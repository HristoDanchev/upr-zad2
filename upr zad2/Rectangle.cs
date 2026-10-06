using System;
using System.Collections.Generic;
using System.Text;

namespace upr_zad2
{
    internal class Rectangle
    {
        private double a;
        private double b;

        public Rectangle()
        {
            this.a = 1;
            this.b = 1;
        }

        public Rectangle(double a, double b)
        {
            if (a > 0)
            {
                this.a = a;
            }
            else
            {
                this.a = 1; 
            }

            if (b > 0)
            {
                this.b = b;
            }
            else
            {
                this.b = 1;
            }
        }

        public double GetArea()
        {
            return this.a * this.b;
        }
    }
}

