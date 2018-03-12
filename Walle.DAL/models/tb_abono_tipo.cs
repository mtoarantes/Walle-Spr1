namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_abono_tipo")]
    public partial class tb_abono_tipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_abono_tipo()
        {
            tb_abono = new HashSet<tb_abono>();
        }

        [Key]
        public int Cod_Abono_Tipo { get; set; }

        [StringLength(45)]
        public string Des_Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_abono> tb_abono { get; set; }
    }
}
