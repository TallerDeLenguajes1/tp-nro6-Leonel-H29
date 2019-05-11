using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado=0;
            char operacion, opcion='s';

            do {
                Console.WriteLine("--Elija un numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("--Elija una operacion (+ , - , * , /): ");
                operacion = char.Parse(Console.ReadLine());
                Console.WriteLine("--Elija un numero: ");
                num2 = int.Parse(Console.ReadLine());
                switch (operacion) {
                    case '+':
                        resultado = sumar(num1, num2);
                        break;
                    case '-':
                        resultado=restar(num1, num2);
                        break;
                    case '*':
                        resultado=producto(num1, num2);
                        break;
                    case '/':
                        resultado=cociente(num1, num2);
                        break;
                    default: break;
                }
                Console.WriteLine("--El resultado es: " + resultado);
                opcion = seguir();

            } while (opcion == 's' || opcion == 'S');
            Console.ReadKey();


        }

        //Funcion para sumar
        static int sumar(int num1, int num2) {
            int result = num1 + num2;
            return result;
        }
        //Funcion para restar
        static int restar(int num1, int num2){
            int result = num1 - num2;
            return result;
        }
        //Funcion para multiplicar
        static int producto(int num1, int num2){
            int result = num1 * num2;
            return result;
        }
        //Funcion para dividir
        static int cociente(int num1, int num2){
            int result = num1 / num2;
            return result;
        }
        //Funcion para saber si el usuario desea continuar
        static char seguir(){
            char letra;

            Console.WriteLine("--Desea continuar? (S/N) ");
            letra = char.Parse(Console.ReadLine());
            while (letra != 'S' && letra != 's' && letra != 'N' && letra != 'n') {
                letra = char.Parse(Console.ReadLine());
            }
            return letra;
        }
    }
}
