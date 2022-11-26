using System;

namespace Model
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero");
            int resultado = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: ");
            Console.WriteLine( resultado - (resultado * 15 / 100));
           





        }


    }
}