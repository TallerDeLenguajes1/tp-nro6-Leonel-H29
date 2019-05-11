using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, num_inver;

            //Solicitar un numero al usuario
            Console.WriteLine("--Escriba un numero: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("--Numero ingresado: " + num);
            //

            if (num <=0) {
                Console.WriteLine("--No se puede invertir el numero ");
                Console.ReadKey();
                Environment.Exit(1);
            }   
            resto = num % 10;
            num = num / 10;
            num_inver = resto * 10;
            while (num > 0) {
                resto = num % 10;
                num = num / 10;
                num_inver = (num_inver + resto)* 10;
            }
            num_inver = (num_inver + num)/10;

            Console.WriteLine("--Numero invertido: " + num_inver);
            Console.ReadKey();
        }
    }
}
