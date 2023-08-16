using System;
using System.Collections.Generic;
using System.Text;

namespace Operator_Overloading
{
    class Complex
    {
        private int real,imaginary;
        public Complex()
        {
                
        }
        public Complex(int real,int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator + (Complex c1, Complex c2)
        {

            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
            //Complex temp = new Complex();
            //temp.real = c1.real + c2.real;
            //temp.imaginary = c1.imaginary + c2.imaginary;
            //return temp;
        }
        public static Complex operator +(Complex c1, int c2)
        {

            return new Complex(c1.real + c2, c1.imaginary + c2);
            //Complex temp = new Complex();
            //temp.real = c1.real + c2.real;
            //temp.imaginary = c1.imaginary + c2.imaginary;
            //return temp;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);

            //Complex temp = new Complex();
            //temp.real = c1.real - c2.real;
            //temp.imaginary = c1.imaginary - c2.imaginary;
            //return temp;
        }
        public static bool operator <(Complex c1, Complex c2)
        {
          if(c1.real<c2.real  && c1.imaginary < c2.imaginary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Complex c1, Complex c2)
        {
            if (c1.real > c2.real && c1.imaginary >c2.imaginary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Complex c1,Complex c2)
        {
            if(c1.real==c2.real && c1.imaginary == c2.imaginary)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool operator!=(Complex c1, Complex c2)
        {
            if (c1.real != c2.real && c1.imaginary != c2.imaginary)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} \t {1} ",real,imaginary);
        }
    }
}
