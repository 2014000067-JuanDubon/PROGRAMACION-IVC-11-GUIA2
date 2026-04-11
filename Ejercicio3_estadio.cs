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

            Console.WriteLine("1 Palco");
            Console.WriteLine("2 Tribuna");
            Console.WriteLine("3 Preferencia");
            Console.WriteLine("4 General");

            Console.Write("Opcion: ");
            opc = int.Parse(Console.ReadLine());

            Console.Write("Cantidad: ");
            cant = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1: Console.WriteLine(cant * 300); break;
                case 2: Console.WriteLine(cant * 100); break;
                case 3: Console.WriteLine(cant * 50); break;
                case 4: Console.WriteLine(cant * 30); break;
                default: Console.WriteLine("Error"); break;
            }

            Console.ReadKey();
        }
    }
}
