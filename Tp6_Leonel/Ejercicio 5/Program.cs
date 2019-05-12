using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args){
            string mail = "";
            string web = "";
            string sub_cad1_web = "www.";
            string sub_cad2_web = ".com";


            Console.WriteLine("---Ingrese la direccion de una pagina web: ");
            web = Console.ReadLine();
            if(web.Contains(sub_cad1_web)==true && web.Contains(sub_cad2_web)==true){
                Console.WriteLine("Direccion web valida");
            }
            else Console.WriteLine("Direccion web no valida");

            Console.WriteLine("---Ingrese su correo");
            mail = Console.ReadLine();
            if(mail.Contains("@")==true && mail.Contains(sub_cad2_web)==true){
                Console.WriteLine("Correo electronico valido");
            }
            else Console.WriteLine("Correo electronico no valido");

            Console.ReadKey();
        }
    }
}
