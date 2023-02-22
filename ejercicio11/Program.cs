using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, n3;
        int mayor, medio, menor;

        Console.WriteLine("ingrese 3 numeros separados por la tecla enter:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());

        if (n1 > n2 && n1 > n3)
        {
            mayor = n1;

            if (n2 > n3)
            {
                medio = n2;
                menor = n3;
            }
            else
            {
                medio = n3;
                menor = n2;
            }
        }
        else if(n2 > n1 && n2 > n3)
        {
            mayor = n2;

            if (n1 > n3)
            {
                medio = n1;
                menor = n2;
            }
            else
            {
                medio = n3;
                menor = n1;
            }
        }
        else
        {
            mayor = n3;

            if (n1 > n2)
            {
                medio = n1;
                menor = n2;
            }
            else
            {
                medio = n2;
                menor = n1;
            }
        }
        Console.WriteLine("A continuacion los valores ordenados de menor a mayor: " + menor + ", " + medio + ", " + mayor + ".");
        
        

        }
    }
}
