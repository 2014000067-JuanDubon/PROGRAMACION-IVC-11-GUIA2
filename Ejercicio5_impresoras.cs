using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc, cant;

            Console.Write("Cantidad: ");
            cant = int.Parse(Console.ReadLine());

            Console.WriteLine("1 Efectivo");
            Console.WriteLine("2 Tarjeta");
            Console.WriteLine("3 Vale");

            Console.Write("Opcion: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1: Console.WriteLine(cant * 650 * 1.12 * 0.90); break;
                case 2: Console.WriteLine(cant * 650 * 1.12 * 0.95); break;
                case 3: Console.WriteLine(cant * 650 * 1.12 * 0.85); break;
                default: Console.WriteLine("Error"); break;
            }

            Console.ReadKey();
        }
    }
}
