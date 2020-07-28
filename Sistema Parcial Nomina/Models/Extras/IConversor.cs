using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Parcial_Nomina.Models.Extras
{
    public interface IConversor
    {
        double Convertir(double valor, string tipo);
    }
}
