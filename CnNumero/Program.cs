using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnNumero
{
    internal class Program
    {
        /// <summary>
        /// Nombre:Viviana Muñoz
        /// Fecha:26/02/2023
        /// Descripcion:Este programa solicta tres numeros e imprime el numero mayor y menor.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Solicita datos
            Console.WriteLine("Ingrese el valor del primer numero");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo numero");
            double valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tercer numero");
            double valor3 = double.Parse(Console.ReadLine());

            CompararNumero(valor1, valor2, valor3);
            CompararMenor(valor1, valor2, valor3);
        }

        //Metodos
        static void CompararNumero(double valor1, double valor2, double valor3)
        {

            if (valor1 > valor2 & valor1 > valor3)
            {
                Console.WriteLine("El numero mayor es:" + valor1);
            }

            else if (valor2 > valor1 & valor2 > valor3)
            {
                Console.WriteLine("El numero mayor es:" + valor2);
            }

            else if (valor3 > valor1 & valor3 > valor2)
            {
                Console.WriteLine("El numero mayor es:" + valor3);
            }


        }


        static void CompararMenor(double valor1, double valor2, double valor3)
        {
            if (valor1 < valor2 & valor1 < valor3)
            {
                Console.WriteLine("El numero menor es:" + valor1);
            }

            else if (valor2 < valor1 & valor2 < valor3)
            {
                Console.WriteLine("El numero menor es:" + valor2);
            }

            else if (valor3 < valor1 & valor3 < valor2)
            {
                Console.WriteLine("El numero menor es:" + valor3);
            }
            Console.ReadKey();
        }
    }
}
