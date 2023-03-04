using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");

            Console.WriteLine("Seleccione que operacion desea realizar (escriba el número correspondiente :3):");
            Console.Write("1");
            Console.WriteLine("  SUMA");
            Console.Write("2");
            Console.WriteLine("  RESTA");
            Console.Write("3");
            Console.WriteLine("  MULTIPLICACIÓN");
            Console.Write("4");
            Console.WriteLine("  DIVISIÓN");

            string value0 = Console.ReadLine();
            int value0Number = Int32.Parse(value0);

            Console.WriteLine("Ingrese el valor 1");
            string value1 = Console.ReadLine();
            int value1Number = Int32.Parse(value1);

            Console.WriteLine("Ingrese el valor 2");
            string value2 = Console.ReadLine();
            int value2Number = Int32.Parse(value2);

            // el "if" es algo que recuerdo de introducción a la programación, asi que lo quise agregar


            if(value0 == "1")
            {
                Console.Write("El resultado de la suma es: ");
                Console.Write(value1Number + value2Number);
                Console.Write(" :D  ");
            }

            if(value0 == "2")
            {
                Console.Write("El resultado de la resta es: ");
                Console.Write(value1Number - value2Number);
                Console.Write(" :D  ");
            }

            if(value0 == "3")
            {
                Console.Write("El resultado de la multiplicación es: ");
                Console.Write(value1Number * value2Number);
                Console.Write(" :D  ");
            }

            if(value0 == "4")
            {
                Console.Write("El resultado división es: ");
                Console.Write(value1Number / value2Number);
                Console.Write(" :D  ");
            }
        }
    }
}
