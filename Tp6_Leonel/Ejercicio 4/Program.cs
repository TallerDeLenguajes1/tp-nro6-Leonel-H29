using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola Mundo";          

            Console.WriteLine("--Texto ingresado: " + cadena);

            //Longitud
            int longitud;
            longitud = (cadena.Length);
            Console.WriteLine("--La longitud es: " + longitud);

            //Concatenacion
            string cadena2 = "Les deseo buen dia";
            Console.WriteLine("--Texto a unir: " + cadena2);
            //frase_completa = String.Concat(cadena, cadena2);
            string frase_completa = "";
            frase_completa = cadena + ", " + cadena2;
            Console.WriteLine("--Texto concatenado: " + frase_completa);

            //Subcadena
            string sub_cadena = "";
            sub_cadena = cadena.Substring(5, 5);
            Console.WriteLine("--Subcadena: " + sub_cadena);
            if (frase_completa.Contains(sub_cadena) == true) {
                Console.WriteLine("Pertenece al texto ingresado ");
            }
            else Console.WriteLine("No pertenece al texto ingresado ");


            //Recorrer cadena
            Console.WriteLine("--Recorrer cadena: ");
            foreach (char array in cadena) {
                Console.WriteLine(array);
            }

            //Mayuscula y minuscula
            string mayuscula, minuscula;
            mayuscula = cadena.ToUpper();
            minuscula = cadena.ToLower();
            Console.WriteLine("--Texto en mayuscula: " + mayuscula);
            Console.WriteLine("--Texto en minuscula: " + minuscula);
           
            //Comparar cadenas
            string cadena3 = "Hola chavos";
            int comparacion = 0;
            Console.WriteLine("--Texto a comparar: " + cadena3);
            comparacion = String.Compare(cadena, cadena3);
            if (comparacion == 0) {
                Console.WriteLine("La frase es igual");
            }
            else Console.WriteLine("La frase es distinta");

            //Calculadora
            Calculadora();
            //Console.ReadKey();
        }
        static void Calculadora(){
            int num1 = 0, num2 = 0, resultado = 0;
            char operacion = ' ', opcion = 's';
            string cadena = "";

            do{
                Console.WriteLine("---Escriba una operacion: ");
                cadena = Console.ReadLine();
                //Veo el primer numero

                //Veo la operacion
                if (cadena.Contains("+")==true) {
                    operacion = '+';
                    string[] partes = cadena.Split(operacion);
                    num1 = Convert.ToInt32(partes[0]);
                    num2 = Convert.ToInt32(partes[1]);
                }
                if (cadena.Contains("-") == true){
                    operacion = '-';
                    string[] partes = cadena.Split(operacion);
                    num1 = Convert.ToInt32(partes[0]);
                    num2 = Convert.ToInt32(partes[1]);
                }
                if (cadena.Contains("*") == true){
                    operacion = '*';
                    string[] partes = cadena.Split(operacion);
                    num1 = Convert.ToInt32(partes[0]);
                    num2 = Convert.ToInt32(partes[1]);
                }
                if (cadena.Contains("/") == true){
                    operacion = '/';
                    string[] partes = cadena.Split(operacion);
                    num1 = Convert.ToInt32(partes[0]);
                    num2 = Convert.ToInt32(partes[1]);
                }

                //Veo el segundo numero
               
                switch (operacion){
                    case '+':
                        resultado = sumar(num1, num2);
                        Console.WriteLine("--El resultado de " + num1 + "+" + num2 + " es: " + resultado);
                        break;
                    case '-':
                        resultado = restar(num1, num2);
                        Console.WriteLine("--El resultado de " + num1 + "-" + num2 + " es: " + resultado);
                        break;
                    case '*':
                        resultado = producto(num1, num2);
                        Console.WriteLine("--El resultado de " + num1 + "*" + num2 + " es: " + resultado);
                        break;
                    case '/':
                        resultado = cociente(num1, num2);
                        Console.WriteLine("--El resultado de " + num1 + "/" + num2 + " es: " + resultado);
                        break;
                    default: break;
                }
                opcion = seguir();

            } while (opcion == 's' || opcion == 'S');
            Console.ReadKey();
        }
        //Funcion para sumar
        static int sumar(int num1, int num2){
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
            while (letra != 'S' && letra != 's' && letra != 'N' && letra != 'n')
            {
                letra = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            return letra;
        }
    }
}