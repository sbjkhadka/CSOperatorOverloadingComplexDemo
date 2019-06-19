using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c0 = new Complex(-2, 3);
            Complex c1 = new Complex(-2, 3);
            Complex c2 = new Complex(1, -2);
            Complex c3 = new Complex(3, 9);

            Console.WriteLine($"{c0}");
            Console.WriteLine(c1);

            Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");

            Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2} and inverse of tan is({c3.Argument:f2})");
           
            Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
            Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");
            Console.WriteLine($"negating {c3} gives {-c3}");
            Console.WriteLine($"Multiplying {c0} and {c1} gives {c0*c1}");

            

        }
    }
}
