using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
        int numero;

        Console.WriteLine("Ingrese un numero:");
        numero = int.Parse(Console.ReadLine());

        if(numero % 5 == 0)
            Console.WriteLine("Es multiplo de 5");
        else
            Console.WriteLine("No es multiplo de 5");
        }
    }
}
