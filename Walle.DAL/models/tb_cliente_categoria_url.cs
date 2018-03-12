namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_cliente_categoria_url")]
    public partial class tb_cliente_categoria_url
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente_categoria_url()
        {
            tb_coleta = new HashSet<tb_coleta>();
        }

        [Key]
        public int Cod_Categoria_url { get; set; }

        public int Cod_Categoria_App { get; set; }

        public int Cod_Categoria { get; set; }

        [StringLength(100)]
        public string Des_Nome { get; set; }

        public bool? Bol_Like { get; set; }

        [StringLength(45)]
        public string Dt_Virgencia_Inicio { get; set; }

        [StringLength(45)]
        public string Dt_Virgencia_Fim { get; set; }

        public virtual tb_categoria tb_categoria { get; set; }

        public virtual tb_cliente_categoria_app tb_cliente_categoria_app { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_coleta> tb_coleta { get; set; }
    }
}
