namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_programa_lista")]
    public partial class tb_programa_lista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_programa_lista()
        {
            tb_cliente_categoria_app = new HashSet<tb_cliente_categoria_app>();
        }

        [Key]
        public int Cod_Programa_Lista { get; set; }

        public int Cod_Programa_Tipo { get; set; }

        [StringLength(150)]
        public string Des_Nome { get; set; }

        [StringLength(150)]
        public string Des_Executavel { get; set; }

        public int Cod_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_categoria_app> tb_cliente_categoria_app { get; set; }

        public virtual tb_programa_tipo tb_programa_tipo { get; set; }
    }
}
