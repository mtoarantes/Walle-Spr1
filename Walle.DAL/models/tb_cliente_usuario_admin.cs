namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_cliente_usuario_admin")]
    public partial class tb_cliente_usuario_admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente_usuario_admin()
        {
            tb_abono = new HashSet<tb_abono>();
        }

        [Key]
        public int Cod_Cliente_Usuario_Admin { get; set; }

        public int Cod_Perfil { get; set; }

        [StringLength(100)]
        public string Des_Nome { get; set; }

        [StringLength(300)]
        public string Des_Nome_Completo { get; set; }

        [StringLength(150)]
        public string Des_Email_Login { get; set; }

        [StringLength(50)]
        public string Des_Password { get; set; }

        public bool? Bol_Bloqueado { get; set; }

        public bool? Bol_Ativo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Cadastro { get; set; }

        [Required]
        [StringLength(125)]
        public string Des_Verificacao { get; set; }

        public int Cod_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_abono> tb_abono { get; set; }

        public virtual tb_perfil tb_perfil { get; set; }
    }
}
