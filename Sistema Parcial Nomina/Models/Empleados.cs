//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_Parcial_Nomina.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Empleados
    {
        public int Id { get; set; }
        [Required]
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }

        [Required]
        public string Email { get; set; }
        public string Departamento { get; set; }
        [Required]
        public string Cargo { get; set; }
        public Nullable<System.DateTime> Fecha_ingreso { get; set; }
        public Nullable<double> Salario { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
