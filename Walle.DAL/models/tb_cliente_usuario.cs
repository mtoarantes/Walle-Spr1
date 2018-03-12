namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_cliente_usuario")]
    public partial class tb_cliente_usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente_usuario()
        {
            tb_coleta = new HashSet<tb_coleta>();
            tb_log_acoes = new HashSet<tb_log_acoes>();
        }

        [Key]
        public int Cod_Cliente_Usuario { get; set; }

        public int Cod_Cliente { get; set; }

        public int Cod_Grupo { get; set; }

        [StringLength(150)]
        public string Des_Nome_Completo { get; set; }

        [StringLength(150)]
        public string Des_Usuario_Rede { get; set; }

        public bool? Bol_Ativo { get; set; }

        [StringLength(15)]
        public string Des_CPF { get; set; }

        [StringLength(45)]
        public string Des_Matricula { get; set; }

        [StringLength(10)]
        public string Dt_Cadastro { get; set; }

        [StringLength(10)]
        public string Dt_Nascimento { get; set; }

        [StringLength(10)]
        public string Dt_Contratacao { get; set; }

        [StringLength(10)]
        public string Dt_Inativo { get; set; }

        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_grupo tb_grupo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_coleta> tb_coleta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_acoes> tb_log_acoes { get; set; }
    }
}
