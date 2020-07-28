using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Parcial_Nomina.Models.Extras
{
    public class Divisa : IConversor
    {
        public double Convertir(double valor, string moneda)
        {
            double tasa = 58.55;
            if(moneda != "dop")
            {
                return valor * tasa;
            }
            else
            {
                return valor / tasa;
            }
        }
    }
}


