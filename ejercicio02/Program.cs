using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        float n1, n2, r;

        Console.WriteLine("Ingrese dos numeros separados por la tecla enter: ");
        n1 = float.Parse(Console.ReadLine());
        n2 = float.Parse(Console.ReadLine());

        if (n1 > n2){
            r = n1 - n2;
            Console.WriteLine("El resultado de la resta de los dos numeros es: " + r);
        }
        else if (n1 == n2){
                r = n1 + n2;
                Console.WriteLine("El resultado de la suma de los dos numeros es: " + r);
        }
        else{
                r = n1 * n2;
                Console.WriteLine("El resultado del producto de los dos numeros es: " + r);
        }
        }

    }
}
