//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HC.WebApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class afiliacion
    {
        [Key]
        public int Persona_id { get; set; }
        public Nullable<System.DateTime> Fecha_Vencimiento { get; set; }
        public string Num_Afiliado { get; set; }
        public int ObraSocial_id { get; set; }
        public int Persona_Persona_id { get; set; }
    }
}
