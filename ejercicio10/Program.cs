﻿using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, n3, n4;

        Console.WriteLine("ingrese 4 numeros separados por la tecla enter:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        if (n1 == n2 && n2 == n3 && n3 == n4)
            Console.WriteLine("Son todos los numeros iguales");
        }
    }
}
