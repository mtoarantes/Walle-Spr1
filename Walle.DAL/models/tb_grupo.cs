namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_grupo")]
    public partial class tb_grupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_grupo()
        {
            tb_cliente_categoria_app = new HashSet<tb_cliente_categoria_app>();
            tb_cliente_usuario = new HashSet<tb_cliente_usuario>();
            tb_usuario = new HashSet<tb_usuario>();
        }

        [Key]
        public int Cod_Grupo { get; set; }

        [StringLength(100)]
        public string Des_Nome { get; set; }

        [StringLength(10)]
        public string Dt_Cadastro { get; set; }

        [StringLength(10)]
        public string Dt_Inativo { get; set; }

        public int? Cod_Area { get; set; }

        public int? Bol_Ativo { get; set; }

        public virtual tb_area tb_area { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_categoria_app> tb_cliente_categoria_app { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_usuario> tb_cliente_usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario> tb_usuario { get; set; }
    }
}
