using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            char l;

        Console.Write("Digite una letra: ");
        l = char.Parse(Console.ReadLine());

        switch (l)
        {
            case 'A':
            case 'a': Console.WriteLine("Excelente"); break;
            case 'B':
            case 'b': Console.WriteLine("Bueno"); break;
            case 'C':
            case 'c': Console.WriteLine("Regular"); break;
            case 'D':
            case 'd': Console.WriteLine("Deficiente"); break;
            case 'F':
            case 'f': Console.WriteLine("Reprobado"); break;
            default: Console.WriteLine("Error"); break;
        }
        Console.ReadKey();
    }
}
}