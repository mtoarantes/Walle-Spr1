namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_cliente_categoria_app")]
    public partial class tb_cliente_categoria_app
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente_categoria_app()
        {
            tb_cliente_categoria_page = new HashSet<tb_cliente_categoria_page>();
            tb_cliente_categoria_url = new HashSet<tb_cliente_categoria_url>();
        }

        [Key]
        public int Cod_Categoria_App { get; set; }

        public int Cod_Grupo { get; set; }

        public int Cod_Categoria { get; set; }

        [StringLength(100)]
        public string Des_Nome { get; set; }

        public bool? Bol_Like { get; set; }

        [StringLength(45)]
        public string Dt_Vigencia_Inicio { get; set; }

        [StringLength(45)]
        public string Dt_Vigencia_Fim { get; set; }

        public int? Cod_Programa_Lista { get; set; }

        public virtual tb_categoria tb_categoria { get; set; }

        public virtual tb_grupo tb_grupo { get; set; }

        public virtual tb_programa_lista tb_programa_lista { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_categoria_page> tb_cliente_categoria_page { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_categoria_url> tb_cliente_categoria_url { get; set; }
    }
}
