using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Calculation
    {
        public double answer { get; private set; }
        public Calculation()
        {

        }

        public void Addition(double num1, double num2)
        {
            answer = num1 + num2;
        }
    }
}