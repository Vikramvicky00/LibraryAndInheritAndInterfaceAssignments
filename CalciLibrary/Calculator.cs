using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalciLibrary
{
    public class Calculator
    {
        public int Addition(int i, int j)
        {
            return i + j;

        }
        public int Subtraction(int i, int j)
        {
            if (j != 0)
            {
                return i - j;
            }
            return i;

        }

        public int Multiply(int i, int j)
        {
            if (j != 0)
            {
                return i * j;
            }
            return 0;
        }

        public int Division(int i, int j)
        {
            if (j != 0)
            {
                return i / j;
            }
            else {
                Console.WriteLine("Divide by zero not possible");
                return 0;
            }
           
        }
        public int DivisionWithRem(int i, int j)
        {
            if (j != 0)
            {  
                return  Math.DivRem(i, j, out int ans);
            }
            else
            {
                Console.WriteLine("Divide by zero not possible");
                return 0;
            }

        }

        public double SquareRootOfNumber(double i)
        {
            return Math.Sqrt(i);


        }

    }
}
