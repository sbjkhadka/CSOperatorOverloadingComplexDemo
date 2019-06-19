using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexDemo
{
    class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }
        public double Argument {
            get
            {
                return Math.Atan(Imaginary / Real);
            }
        }
        public double Modulus {
            get
            {
                return Math.Sqrt(Math.Pow(Real,2)+Math.Pow(Imaginary,2));
            }
        }



        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"<{Real},{Imaginary}>";
        }
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return (lhs.Real == rhs.Real) && (lhs.Imaginary == rhs.Imaginary);
        }
          
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return (lhs.Real != rhs.Real) || (lhs.Imaginary != rhs.Imaginary);
            
        }
        public static Complex operator -(Complex complex)
        {
            return new Complex(-complex.Real, -complex.Imaginary);

        }
        public static Complex operator *(Complex lhs, Complex rhs)
        {
            //<a, b> * <c, d> = <ac-bd, ad+bc>. 
            return new Complex((lhs.Real * rhs.Real) - (lhs.Imaginary * rhs.Imaginary), (lhs.Real * rhs.Imaginary) + (lhs.Imaginary * rhs.Real));
        }
            
        


    }
}
