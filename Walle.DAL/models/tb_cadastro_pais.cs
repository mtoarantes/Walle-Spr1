namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_cadastro_pais")]
    public partial class tb_cadastro_pais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cadastro_pais()
        {
            tb_cadastro_estado = new HashSet<tb_cadastro_estado>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cod_Pais { get; set; }

        [StringLength(60)]
        public string Des_Nome { get; set; }

        [StringLength(10)]
        public string Des_Sigla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cadastro_estado> tb_cadastro_estado { get; set; }
    }
}
