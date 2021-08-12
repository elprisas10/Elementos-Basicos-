using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_Basicos_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-Hacer   un   programa que   transforme   de   grados   centígrados   a   grados Fahrenheit.
            float Celsius;

            Console.WriteLine("Ingrese los grados Celsius");
            Celsius = float.Parse(Console.ReadLine());

            Console.Write("\nGrados Fahrenheit: " + ((Celsius * 1.8F) + 32) );

            Console.ReadKey();


        }
    }
}
