namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_log_acoes_tipo")]
    public partial class tb_log_acoes_tipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_log_acoes_tipo()
        {
            tb_log_acoes = new HashSet<tb_log_acoes>();
        }

        [Key]
        public int Cod_Log_Acoes_Tipo { get; set; }

        [StringLength(45)]
        public string Des_Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_acoes> tb_log_acoes { get; set; }
    }
}
