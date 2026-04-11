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
            int opc;
            double m;

            Console.WriteLine("1 Pies");
            Console.WriteLine("2 Centimetros");
            Console.WriteLine("3 Pulgadas");

            Console.Write("Opcion: ");
            opc = int.Parse(Console.ReadLine());

            Console.Write("Metros: ");
            m = double.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1: Console.WriteLine(m * 3.28); break;
                case 2: Console.WriteLine(m * 100); break;
                case 3: Console.WriteLine(m * 39.37); break;
                default: Console.WriteLine("Error"); break;
            }

            Console.ReadKey();
        }
    }
}
