using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_Basicos_1._0
{
    class Impuestos_de_productos
    {
        public static void Main(string[] args)
        {
            //5-Hacer un programa que calcule el impuesto de un producto, pero coloque un impuesto del 0% si el producto es medicina.
            double precio, costo, porcentaje;
            Console.Write("Ingrese el precio del producto: ");
            costo = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el porcentaje de descuento: ");
            porcentaje = double.Parse(Console.ReadLine());
            precio = costo - costo * porcentaje / 100;
            Console.WriteLine("El precio final del producto es: " + precio);
            Console.ReadLine();
        }
    }
}
