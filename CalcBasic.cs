using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
             int opc;
        double a, b;

        Console.WriteLine("1 Suma");
        Console.WriteLine("2 Resta");
        Console.WriteLine("3 Multiplicacion");
        Console.WriteLine("4 Division");

        Console.Write("Opcion: ");
        opc = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite dos numeros:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        switch (opc)
        {
            case 1: Console.WriteLine(a + b); break;
            case 2: Console.WriteLine(a - b); break;
            case 3: Console.WriteLine(a * b); break;
            case 4: Console.WriteLine(a / b); break;
            default:
                Console.WriteLine("Error");
                break;
        }
        Console.ReadKey();
    }
}
}
