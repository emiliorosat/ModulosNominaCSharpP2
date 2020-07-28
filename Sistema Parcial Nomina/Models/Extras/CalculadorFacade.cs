using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Parcial_Nomina.Models.Extras
{
    public class CalculadorFacade
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }
        public double resultado { get; set; }
        public string operacion {get; set;}

        private Calculadora calculadora = Calculadora.GetCalculadora();

        public CalculadorFacade()
        {
            this.resultado = 0;
        }

        public void EjecutarOperacion()
        {
            string operacion = this.operacion.ToLower();

            switch (operacion)
            {
                case "suma": {
                        this.resultado = calculadora.Suma(this.valor1, this.valor2);
                            }
                    break;
                case "resta":
                    {
                        this.resultado = calculadora.Resta(this.valor1, this.valor2);
                    } break;
                case "multiplica":
                    {
                        this.resultado = calculadora.Multiplicacion(this.valor1, this.valor2);
                    }break;
                case "divide":
                    {
                        this.resultado = calculadora.Division(this.valor1, this.valor2);
                    }break;

            }

            this.resultado = Math.Round(this.resultado, 4);
        }
    }
}