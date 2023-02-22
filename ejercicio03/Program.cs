using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, r;

        Console.WriteLine("Ingrese dos numeros separados por la tecla enter:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        if(n2 != 0){
            r = n1 / n2;
            Console.WriteLine("La division del primer numero por el segundo es: " + r);
        }
        else
            Console.WriteLine("No se puede dividir por 0");
        }
    }
}
