using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, n3, n4;

        Console.WriteLine("Ingrese 4 numeros separados por la tecla enter:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        if(n1 > n2 && n2 > n3 && n3 > n4)
            Console.WriteLine("Estan ordenados de mayor a menor.");
        else
            Console.WriteLine("No estan ordenados de mayor a menor.");
        }
    }
}
