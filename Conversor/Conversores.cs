using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    public class Conversores
    {

        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public int numeroe1 { get; set; }
        public int numeroe2 { get; set; }

        public Conversores()
        {
        }

        public Conversores(double numero1, double numero2, int numeroe1, int numeroe2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            this.numeroe1 = numeroe1;
            this.numeroe2 = numeroe2;
        }

        public double MetrosaCentimetros(double num)
        {
            Numero1 = num;
            double conversion = Numero1 / 100;
            return conversion;

        }

        public int SegundosaMinutos(int segundos)
        {
            numeroe1 = segundos;
            int conversion = numeroe1 / 60;
            return conversion;

        }

        public double CelciusAFahrenheit(double Ce)
        {
            Numero1 = Ce;
            double conversion = (Numero1 * 9 / 5) + 32;
            return conversion;
        }


    }
}
