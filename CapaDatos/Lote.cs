//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lote
    {
        public int id_lote { get; set; }
        public int id_odf { get; set; }
        public string observaciones { get; set; }
        public int Producto { get; set; }
        public string Cantidad { get; set; }
        public int Unidad { get; set; }
    
        public virtual ODF ODF { get; set; }
        public virtual Producto Producto1 { get; set; }
        public virtual Productos Productos { get; set; }
        public virtual UnidadesOdf UnidadesOdf { get; set; }
    }
}