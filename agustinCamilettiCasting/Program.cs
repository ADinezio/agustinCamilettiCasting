using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agustinCamilettiCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Pasamos de forma implicita de int a double.
            int numeroInt = 28;
            double numeroDouble = numeroInt;

            //Pasamos de forma explicita de double a int.
            double numDouble = 54.256;
            int num = Convert.ToInt32(numDouble);

            //Pasamos de forma explicita de string a int.
            Console.WriteLine("Ingrese su edad : ");
            int edad = Int32.Parse(Console.ReadLine());

            //Pasamos de forma explicita de int a float.
            float PI = 3.1416F;
            int numeroPi= Convert.ToInt32(PI);

            //Pasamos de forma explicita de double a int.
            double number = 9.65;
            int myNum = (int)number;

        }
    }
}
