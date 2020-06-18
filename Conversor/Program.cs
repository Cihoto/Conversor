using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversores mac = new Conversores();
            Console.WriteLine("Ingrese la cantidad de centimetros que desee covertir en metros");
            double num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("La cantidad de metros es: " + mac.MetrosaCentimetros(num));
            Console.WriteLine("Ingrese la cantidad de Segundos que desee covertir en Minutos");
            int segundos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("La cantidad de minutos es  es: " + mac.SegundosaMinutos(segundos));
            Console.WriteLine("Ingrese la cantidad de Grados Celcius que desee covertir en Grados Fahrenheit");
            double grados = Int32.Parse(Console.ReadLine());
            Console.WriteLine("La cantidad de Grados Fahreheit son: " + mac.CelciusAFahrenheit(grados));
        }
    }
}
