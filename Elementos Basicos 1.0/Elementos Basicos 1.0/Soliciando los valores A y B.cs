using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_Basicos_1._0
{
    class Soliciando_los_valores_A_y_B
    {
        static void Main(string[] args)
        {
            //2-Solicitar a un usauriodos valores (a y b), y el programa mostrará el resultado de la operación (a+b)*(a-b) y el resultado de la operación a2-b
            double valor_A;
            Console.Write("Ingrese el valor A: ");
            valor_A = Convert.ToInt32(Console.ReadLine());

            double valor_B;
            Console.Write("ingrese el valor B: ");
            valor_B = Convert.ToInt32(Console.ReadLine());

            Double suma;
            suma = valor_A + valor_B;

            double resta;
            resta = valor_A - valor_B;

            Console.WriteLine("El resultado final es : " + suma * resta);
            Console.ReadKey();
        }
    }
    }
