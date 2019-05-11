using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, operacion, resultado = 0;
            int max, min;
            char  opcion = 's';
            double num, resul;

            do
            {
                Console.WriteLine("--Elija una de estas opciones: ");
                Console.WriteLine("1) Sumar: ");
                Console.WriteLine("2) Restar: ");
                Console.WriteLine("3) Multiplicar: ");
                Console.WriteLine("4) Dividir: ");
                Console.WriteLine("5) Valor absoluto: ");
                Console.WriteLine("6) Cuadrado: ");
                Console.WriteLine("7) Raiz Cuadrada: ");
                Console.WriteLine("8) Coseno: ");
                Console.WriteLine("9) Seno: ");
                Console.WriteLine("10) Parte entera de un float: ");
                Console.WriteLine("Ingrese aqui: ");
                operacion = int.Parse(Console.ReadLine());
                
                switch (operacion){
                    //Suma
                    case 1:
                        Console.WriteLine("--Elija un numero: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("--Elija un numero: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = sumar(num1, num2);
                        Console.WriteLine("--El resultado es: " + resultado);
                        break;
                    //Resta
                    case 2:
                        Console.WriteLine("--Elija un numero: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("--Elija un numero: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = restar(num1, num2);
                        Console.WriteLine("--El resultado es: " + resultado);
                        break;
                    //Multiplicacion
                    case 3:
                        Console.WriteLine("--Elija un numero: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("--Elija un numero: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = producto(num1, num2);
                        Console.WriteLine("--El resultado es: " + resultado);
                        break;
                    //Division
                    case 4:
                        Console.WriteLine("--Elija un numero: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("--Elija un numero: ");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = cociente(num1, num2);
                        Console.WriteLine("--El resultado es: " + resultado);
                        break;
                    //Valor Absoluto
                    case 5:
                        Console.WriteLine("--Elija un numero: ");
                        num1 = int.Parse(Console.ReadLine());
                        resultado = Math.Abs(num1);
                        Console.WriteLine("--El resultado es: " + resultado);
                        break;
                    //Cuadrado
                    case 6:
                        Console.WriteLine("--Elija un numero: ");
                        num = double.Parse(Console.ReadLine());
                        resul = Math.Pow(num, 2);
                        Console.WriteLine("--El resultado es: " + resul);
                        break;
                    //Raiz Cuadrada
                    case 7:
                        Console.WriteLine("--Elija un numero: ");
                        num = double.Parse(Console.ReadLine());
                        resul = Math.Sqrt(num);
                        Console.WriteLine("--El resultado es: " + resul);
                        break;
                    //Coseno
                    case 8:
                        Console.WriteLine("--Elija un numero: ");
                        num = double.Parse(Console.ReadLine());
                        resul = Math.Cos(num);
                        Console.WriteLine("--El resultado es: " + resul);
                        break;
                    //Seno
                    case 9:
                        Console.WriteLine("--Elija un numero: ");
                        num = double.Parse(Console.ReadLine());
                        resul = Math.Sin(num);
                        Console.WriteLine("--El resultado es: " + resul);
                        break;
                    //Parte entera de un float
                    case 10:
                        Console.WriteLine("--Elija un numero: ");
                        num = double.Parse(Console.ReadLine());
                        resul = Math.Sign(num);
                        Console.WriteLine("--El resultado es: " + resul);
                        break;
                    default: break;
                }
                opcion = seguir();

            } while (opcion == 's' || opcion == 'S');

            Console.WriteLine("--Maximo y minimo entre 2 numeros: ");
            Console.WriteLine("--Elija un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("--Elija un numero: ");
            num2 = int.Parse(Console.ReadLine());
            max = Math.Max(num1, num2);
            min = Math.Min(num1, num2);
            Console.WriteLine("--El maximo numero es: " + max);
            Console.WriteLine("--El minimo numero es: " + min);
            Console.ReadKey();
        }

        //Funcion para sumar
        static int sumar(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        //Funcion para restar
        static int restar(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        //Funcion para multiplicar
        static int producto(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        //Funcion para dividir
        static int cociente(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
        //Funcion para saber si el usuario desea continuar
        static char seguir()
        {
            char letra;

            Console.WriteLine("--Desea continuar? (S/N) ");
            letra = char.Parse(Console.ReadLine());
            while (letra != 'S' && letra != 's' && letra != 'N' && letra != 'n')
            {
                letra = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            return letra;
        }
    }
}
