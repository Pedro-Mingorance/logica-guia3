using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, n3;

        Console.WriteLine("Ingrese la longitud de el primer lado del triangulo:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la longitud de el segundo lado del triangulo:");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la longitud de el tercer lado del triangulo:");
        n3 = int.Parse(Console.ReadLine());


        if(n1 == n2 && n2 == n3 )
            Console.WriteLine("Triangulo equilátero");
        else if(n1 == n2 || n2 == n3 || n1 == n3)
                Console.WriteLine("Triangulo isósceles");
            else
                Console.WriteLine("Triangulo escaleno");
        

        }
    }
}