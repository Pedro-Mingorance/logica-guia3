using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
        double litros, importe, importefinal;

        Console.WriteLine("Ingrese primero los litros y luego el importe total");
        litros = double.Parse(Console.ReadLine());
        importe = double.Parse(Console.ReadLine());

        if (litros > 500){
            importefinal = importe * 0.75;
        }
        else if (litros > 300){
            importefinal = importe * 0.85;
             }
             else if (litros > 100){
                importefinal = importe * 0.90;
                  }
                  else
                    importefinal = importe;

        Console.WriteLine("El total a cobrar es: $" + importefinal);
        
        }
    }
}
