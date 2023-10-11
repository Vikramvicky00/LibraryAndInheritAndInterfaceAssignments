using System;
using CalciLibrary;

namespace AppInheritInterface
{
    internal class CalciMain
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Choose the Below option");
            Console.WriteLine(" 1. Addition \n 2. Subtraction \n 3.Multiplication \n 4. Divison \n 5. Divison With Remainder \n 6. Square Root");
            int opt=Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("You Selected Addition :");
                        Console.WriteLine("Enter Number 1 :");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Number 2 :");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Addition of {0} and {1} is {2}", n1, n2,calculator.Addition(n1, n2));
                        break;
                    case 2:
                        Console.WriteLine("You Selected Subtraction :");
                        Console.WriteLine("Enter Number 1 :");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Number 2 :");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Subtraction of {0} and {1} is {2}", a, b, calculator.Subtraction(a, b));
                        break;
                    case 3:
                        Console.WriteLine("You Selected Multiplication :");
                        Console.WriteLine("Enter Number 1 :");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Number 2 :");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Multiplication of {0} and {1} is {2}", a1, b1, calculator.Multiply(a1, b1));
                        break;
                    case 4:
                        Console.WriteLine("You Selected Division :");
                        Console.WriteLine("Enter Number 1 :");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Number 2 :");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Division of {0} and {1} is {2}", a2, b2, calculator.Division(a2, b2));
                        break;
                    case 5:
                        Console.WriteLine("You Selected Division With Remainder :");
                        Console.WriteLine("Enter Number 1 :");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Number 2 :");
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Division With Remainder of {0} and {1} is {2}", a3, b3, calculator.DivisionWithRem(a3, b3));
                        break;
                    case 6:
                        Console.WriteLine("You Selected Square Root :");
                        Console.WriteLine("Enter Number for Square Root :");
                        double n = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The Square Root of {0} is {1}", n, calculator.SquareRootOfNumber(n));
                        break; 
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;

                }
            
            
        }
    }
}
