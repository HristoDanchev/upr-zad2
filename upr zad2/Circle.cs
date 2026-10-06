using System;
using System.Collections.Generic;
using System.Text;

namespace upr_zad2
{
    internal class Circle
    {
        private double r;


        public Circle()
        {
            this.r = 1;
        }

        public Circle(double r)
        {
            if (r > 0)
            {
                this.r = r;
            }
            else
            {
                this.r = 1;
            }
        }

        public double GetArea()
        {
            return Math.PI * this.r * this.r;
        }
    }
}

