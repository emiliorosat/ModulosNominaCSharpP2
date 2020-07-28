using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Parcial_Nomina.Models.Extras
{
    public class Temperatura : IConversor
    {
        public double Convertir(double valor, string tipo)
        {


            if(tipo != "fahrenheit")
            {
                return (1.8 * valor) + 32;
            }
            else
            {
                return (valor - 32) / 1.8;
            }
        }
    }
}