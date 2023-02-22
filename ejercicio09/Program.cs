using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
        int procesador, ram, disco;
        int preciofinal = 0;

        Console.WriteLine("Ingrese el tipo de procesador:");
        procesador = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tipo de memoria RAM:");
        ram = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese 1 para extender la capacidad del disco o 0 para no extenderlo:");
        disco = int.Parse(Console.ReadLine());

        switch(procesador){
            case 1:
                switch(ram){
                    case 1:
                        preciofinal = 800;
                        break;
                    case 2:
                        preciofinal = 900;
                        break;
                    case 3:
                        preciofinal = 1200;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                    }
                break;
            case 2:
                switch(ram){
                    case 1:
                        preciofinal = 900;
                        break;
                    case 2:
                        preciofinal = 1000;
                        break;
                    case 3:
                        preciofinal = 1400;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                    }
                break;
            case 3:
                switch(ram){
                    case 1:
                        preciofinal = 1000;
                        break;
                    case 2:
                        preciofinal = 1400;
                        break;
                    case 3:
                        preciofinal = 2000;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                    }
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
        if (disco == 1)
            preciofinal += 300;

        if (preciofinal > 300)
            Console.WriteLine("El precio final es: USD$ " + preciofinal);
        }
    }
}
