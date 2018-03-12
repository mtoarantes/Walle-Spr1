namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_programa_tipo")]
    public partial class tb_programa_tipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_programa_tipo()
        {
            tb_programa_lista = new HashSet<tb_programa_lista>();
        }

        [Key]
        public int Cod_Programa_Tipo { get; set; }

        [StringLength(100)]
        public string Des_Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_programa_lista> tb_programa_lista { get; set; }
    }
}
