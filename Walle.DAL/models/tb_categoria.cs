namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_categoria")]
    public partial class tb_categoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_categoria()
        {
            tb_cliente_categoria_app = new HashSet<tb_cliente_categoria_app>();
            tb_cliente_categoria_page = new HashSet<tb_cliente_categoria_page>();
            tb_cliente_categoria_url = new HashSet<tb_cliente_categoria_url>();
        }

        [Key]
        public int Cod_Categoria { get; set; }

        [StringLength(100)]
        public string Des_Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_categoria_app> tb_cliente_categoria_app { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_categoria_page> tb_cliente_categoria_page { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_categoria_url> tb_cliente_categoria_url { get; set; }
    }
}
