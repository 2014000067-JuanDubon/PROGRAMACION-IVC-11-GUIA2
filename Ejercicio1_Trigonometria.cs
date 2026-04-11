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
            double ang;

            Console.WriteLine("1 Seno");
            Console.WriteLine("2 Coseno");
            Console.WriteLine("3 Tangente");

            Console.Write("Opcion: ");
            opc = int.Parse(Console.ReadLine());

            Console.Write("Angulo: ");
            ang = double.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1: Console.WriteLine(Math.Sin(ang * Math.PI / 180)); break;
                case 2: Console.WriteLine(Math.Cos(ang * Math.PI / 180)); break;
                case 3: Console.WriteLine(Math.Tan(ang * Math.PI / 180)); break;
                default: Console.WriteLine("Error"); break;
            }

            Console.ReadKey();
        }
    }
}
