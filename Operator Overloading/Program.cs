using System;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Complex firstObj = new Complex(60, 30);
            Complex secondObj = new Complex(60, 30);
            //Console.WriteLine(firstObj.Equals(secondObj));
            Complex addResult = firstObj + secondObj;
            Complex minusResult = firstObj - secondObj;
            Console.WriteLine("Real \t Imaginary");
            Console.WriteLine(addResult);
            Console.WriteLine(minusResult);
            if (firstObj < secondObj)
            {
                Console.WriteLine("First object is smaller !!!");
            }
            else
            {
                Console.WriteLine("First  object is Greater!!");
            }
            int num1 = 2, num2 = 6;
            int num = num1 + num2;
            Console.WriteLine(firstObj += 1);
        }
        

    }
}
