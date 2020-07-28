using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Parcial_Nomina.Models.Extras
{
    public class Calculadora
    {
        private static Calculadora instance = null;
        private Calculadora()
        {

        }

        public static Calculadora GetCalculadora()
        {
            if(instance == null)
            {
                instance = new Calculadora();
            }

            return instance;
        }

        public double Suma(double val1, double val2)
        {
            return val1 + val2;
        }
        public double Resta(double val1, double val2)
        {
            return val1 - val2;
        }
        public double Multiplicacion(double val1, double val2)
        {
            return val1 * val2;
        }
        public double Division(double val1, double val2)
        {
            return val1 / val2;
        }
    }
}