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
    
    public partial class Diccionario_odfm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Diccionario_odfm()
        {
            this.Cotas_planos = new HashSet<Cotas_planos>();
            this.odfm_insumos = new HashSet<odfm_insumos>();
            this.Of_tecnica_Cod_planos = new HashSet<Of_tecnica_Cod_planos>();
            this.Plano_operaciones = new HashSet<Plano_operaciones>();
        }
    
        public int id_dic_odfm { get; set; }
        public int dic_cab { get; set; }
        public int dic_cod { get; set; }
        public string dic_abr { get; set; }
        public string dic_des { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cotas_planos> Cotas_planos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<odfm_insumos> odfm_insumos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Of_tecnica_Cod_planos> Of_tecnica_Cod_planos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plano_operaciones> Plano_operaciones { get; set; }
    }
}
