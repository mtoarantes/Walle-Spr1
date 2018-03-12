namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_area")]
    public partial class tb_area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_area()
        {
            tb_grupo = new HashSet<tb_grupo>();
        }

        [Key]
        public int Cod_Area { get; set; }

        [StringLength(45)]
        public string Des_Descricao { get; set; }

        public int? Cod_Cliente { get; set; }

        public virtual tb_cliente tb_cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_grupo> tb_grupo { get; set; }
    }
}
