using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Addition
            int a = 10; int b = 20;
            int result= a + b;
            Console.WriteLine("The result addition " +result);

            //Substraction
            result = a - b;
            Console.WriteLine("The result substraction" +result);

            //Division
            result = a / b;
            Console.WriteLine("The result division" +result);

            //Comparsion Operators
            int d = 10;
            if(d==10)
            {
                Console.WriteLine("Hello World ");
            }
            Console.ReadLine();


        }
    }
}
