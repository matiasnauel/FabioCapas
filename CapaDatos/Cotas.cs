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
    
    public partial class Cotas
    {
        public string id_cot { get; set; }
        public int fk_Nombre_Cot { get; set; }
        public int id_prod { get; set; }
        public Nullable<double> max_cot { get; set; }
        public Nullable<double> min_cot { get; set; }
        public int x_pos { get; set; }
        public int y_pos { get; set; }
    
        public virtual DiccionarioDeFabricacion DiccionarioDeFabricacion { get; set; }
        public virtual Producto Producto { get; set; }
    }
}