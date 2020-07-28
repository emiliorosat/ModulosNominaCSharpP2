using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Parcial_Nomina.Models.Extras
{
    public class ConversorContext
    {
        private IConversor _stategy;

        public ConversorContext(IConversor obj)
        {
            this._stategy = obj;
        }
        public void SetStrategy(IConversor obj)
        {
            this._stategy = obj;
        }

        public double Convertir(double val, string tipo)
        {
            return Math.Round(this._stategy.Convertir(val, tipo), 2);
        }
    }
}