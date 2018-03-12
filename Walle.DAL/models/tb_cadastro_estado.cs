namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_cadastro_estado")]
    public partial class tb_cadastro_estado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cadastro_estado()
        {
            tb_cadastro_cidade = new HashSet<tb_cadastro_cidade>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cod_Estado { get; set; }

        [StringLength(75)]
        public string Des_Nome { get; set; }

        [StringLength(5)]
        public string Des_Uf { get; set; }

        public int? Cod_Pais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cadastro_cidade> tb_cadastro_cidade { get; set; }

        public virtual tb_cadastro_pais tb_cadastro_pais { get; set; }
    }
}
