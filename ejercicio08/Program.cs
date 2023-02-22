using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
        double litros;
        double totalxpagar;
        int formadepago = 0;
        const double descuentoxefectivo = 0.9;
        const double precioxlitro0 = 25;
        const double precioxlitro1 = 20;
        const double precioxlitro2 = 15;
        const double precioxlitro3 = 10;
        const int litros1 = 50;
        const int litros2 = 200;
        const int litros3 = 500;

        Console.WriteLine("Ingrese la cantidad de litros vendidos:");
        litros = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tipo de pago: \n1 para efectivo, 0 para cualquier otra forma de pago ");
        formadepago = int.Parse(Console.ReadLine());

        if (litros > litros3)
            totalxpagar = litros * precioxlitro3;
        else if (litros > litros2)
                totalxpagar = litros * precioxlitro2;
            else if (litros > litros1)
                totalxpagar = litros * precioxlitro1;
                else
                    totalxpagar = litros * precioxlitro0;
        
        if (formadepago == 1)
            totalxpagar = totalxpagar * descuentoxefectivo;
        
        Console.WriteLine("El total a pagar es: " + totalxpagar);
        }
    }
}
