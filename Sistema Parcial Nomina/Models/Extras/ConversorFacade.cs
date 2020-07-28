using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Parcial_Nomina.Models.Extras
{
    public class ConversorFacade
    {
        ConversorContext obj;

        public double valor { get; set; }
        public string temp { get; set; }
        public string div { get; set; }
        public string conv { get; set; }

        public double resultado { get; set; }

        public void EjecutarConversion()
        {
           if(this.conv == "Converir Temperatura")
            {
               this.obj = new ConversorContext(new Temperatura());
                this.resultado = obj.Convertir(this.valor, this.temp);
            }
            else
            {
                this.obj = new ConversorContext(new Divisa());
                this.resultado = obj.Convertir(this.valor, this.div);
            }
        }
    }
}