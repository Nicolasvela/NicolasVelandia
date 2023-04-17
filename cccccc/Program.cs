using System;
using System.Collections.Specialized;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("CALCULADORA");
Console.WriteLine();



Console.Write("1");
Console.WriteLine("  SUMA");
Console.Write("2");
Console.WriteLine("  RESTA");
Console.Write("3");
Console.WriteLine("  MULTIPLICACIÓN");
Console.Write("4");
Console.WriteLine("  DIVISIÓN");
Console.Write("5");
Console.WriteLine("  POTENCIACIÓN");
Console.Write("6");
Console.WriteLine("  RAÍZ CUADRADA");
Console.WriteLine();


static double Operation(string option, int number1, int number2)
{

    switch (option)
    {
        case "1":
            return number1 + number2;
            
        case "2":
            return number1 - number2;
            
        case "3":
            return number1 * number2;
            
        case "4":
            return number1 / number2;

        case "5":
            return Math.Pow(number1, number2) ;
        case "6":
            return Math.Sqrt(number1);

    }
    return 0;
    
 
}

Console.WriteLine("Seleccione que operacion desea realizar (escriba el número correspondiente :3):");
string option = Console.ReadLine();


if (option == "5")
{
    int number1;
    Console.Write("Ingrese el valor base :  ");
    number1 = int.Parse(Console.ReadLine());
    int number2;
    Console.Write("Ingrese el exponente:    ");
    number2 = int.Parse(Console.ReadLine());

    Console.Write("RESULTADO:   ");
    double Total = Operation(option, number1, number2);
    Console.WriteLine(Total);
    Console.Write("    (°u°)");
}

if (option == "6")
{
    int number1;
    Console.Write("Ingrese el valor :  ");
    number1 = int.Parse(Console.ReadLine());
    int number2 = 0;
    Console.Write("RESULTADO:   ");
    double Total = Operation(option, number1, number2);
    Console.WriteLine(Total);
    Console.Write("    (°u°)");
}

else
{
    int number1;
    Console.Write("Ingrese el valor 1:  ");
    number1 = int.Parse(Console.ReadLine());
    int number2;
    Console.Write("Ingrese el valor 2:  ");
    number2 = int.Parse(Console.ReadLine());

    Console.Write("RESULTADO:   ");
    double Total = Operation(option, number1, number2);
    Console.WriteLine(Total);
    Console.Write("    (°u°)");


}











