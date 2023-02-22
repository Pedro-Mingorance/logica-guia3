using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        double n1, n2;
        const double aprodirecta = 8;
        const double aproconfinal = 6;

        Console.WriteLine("Ingrese la nota del primer parcial:");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la nota del segundo parcial:");
        n2 = double.Parse(Console.ReadLine());

        if(n1 >= aprodirecta && n2 >= aprodirecta)
            Console.WriteLine("Aprobacion directa");
        else if(n1 >= aproconfinal && n2 >= aproconfinal)
                Console.WriteLine("Rinde examen final");
            else
                Console.WriteLine("Debe recuperar");
        }
    }
}
