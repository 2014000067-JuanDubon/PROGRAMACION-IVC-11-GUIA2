using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
             int opc;

        Console.WriteLine("1");
        Console.WriteLine("2");
        Console.WriteLine("3");
        Console.WriteLine("4");

        Console.Write("Opcion: ");
        opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 1: Console.WriteLine("Hamburguesa"); break;
            case 2: Console.WriteLine("Pizza"); break;
            case 3: Console.WriteLine("Pollo"); break;
            case 4: Console.WriteLine("Ensalada"); break;
            default: Console.WriteLine("Error"); break;
        }
        Console.ReadKey();
    }
}
}