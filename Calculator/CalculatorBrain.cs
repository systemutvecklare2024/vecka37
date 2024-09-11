using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorBrain
    {

        public string Addition(int a, int b)
        {
            var sum = a + b;

            return $"{a} plus {b} blir {sum}";
        }

        public string Subtraction(int a, int b)
        {
            var diff = a - b;
            return $"{a} minus {b} blir {diff}";
        }

        public string Multiplication(int a, int b)
        {
            var product = a * b;

            return $"{a} gånger {b} blir {product}";
        }

        public string Division(int a, int b)
        {
            double quotient = (double)a / b;
            return $"{a} delat med {b} blir {quotient:f}";
        }
    }
}
