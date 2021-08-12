using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementos_Basicos_1._0
{
    class Calculo_de_notas
    {
        static void Main(string[] args)
        {
            //6-Crear un programa que calcule la nota de un estudiante en base a 3notas ingresadas, cada nota equivale a 30%, 35%,  y  25%, deberá mostrar las notas ingresadas, notas con el porcentaje aplicado y la nota final.
            double nota1, nota2, nota3, definitiva;

          
            {

                Console.Write("Ingresar nota numero 1: ");
                nota1 = double.Parse(Console.ReadLine());

                Console.Write("Ingresar nota numero 2: ");
                nota2 = double.Parse(Console.ReadLine());

                Console.Write("Ingresar nota numero 3: ");
                nota3 = double.Parse(Console.ReadLine());

                definitiva = (double) ((nota1 * 0.30) + (nota2 * 0.35) + (nota3 * 0.25));

                
                Console.WriteLine(definitiva);
            }
            Console.ReadKey();
        }

        
    }
}
