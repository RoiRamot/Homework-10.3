using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rationals
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational first = new Rational();
            Rational second = new Rational();
            first.Numerator = 2;
            first.Denominator = 4;
            second.Numerator = 4;
            second.Denominator = 8;

            Console.WriteLine("the numbers are:");
            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());
        
            Console.WriteLine();
            Console.WriteLine("the decimal value is:");
            Console.WriteLine(first.Decimalvalue);
            Console.WriteLine(second.Decimalvalue);
          
            Console.WriteLine();
            Console.WriteLine("the reduced rationals are:");
            Console.WriteLine(first.ReduceRational().ToString());
            Console.WriteLine(second.ReduceRational().ToString());

            Console.WriteLine();
            Console.WriteLine("the added rationals are:");
            Console.WriteLine(first.AddRational(second).ToString());

            Console.WriteLine();
            Console.WriteLine("the Multiply of the rationals are:");
            Console.WriteLine(first.MulRational(second).ToString());

            Console.WriteLine();
            Console.WriteLine("are the two rational equal");
            Console.WriteLine(first.Equals(second));

            Console.WriteLine();
            Console.WriteLine("addition");
            Rational addition = first + second;
            Console.WriteLine(addition.ToString());

            Console.WriteLine();
            Console.WriteLine("subtruct");
            Rational subtruct = first - second;
            Console.WriteLine(subtruct.ToString());

            Console.WriteLine();
            Console.WriteLine("devide");
            Rational devide = first / second;
            Console.WriteLine(devide.ToString());

            Console.WriteLine();
            Console.WriteLine("multiply");
            Rational multiply = first * second;
            Console.WriteLine(multiply.ToString());
            
            Console.ReadLine();
        }
    }

}
