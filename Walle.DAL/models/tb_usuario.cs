namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_usuario")]
    public partial class tb_usuario
    {
        [Key]
        public int Cod_Usuario { get; set; }

        public int Cod_Cliente { get; set; }

        public int Cod_Grupo { get; set; }

        public int Cod_Perfil { get; set; }

        [StringLength(100)]
        public string Des_Pri_Nome { get; set; }

        [StringLength(255)]
        public string Des_Nome_Completo { get; set; }

        [StringLength(50)]
        public string Des_Usuario_Rede { get; set; }

        [StringLength(100)]
        public string Des_Email_Login { get; set; }

        [StringLength(100)]
        public string Des_Senha { get; set; }

        [StringLength(20)]
        public string Des_CPF { get; set; }

        [StringLength(45)]
        public string Des_Matricula { get; set; }

        [StringLength(255)]
        public string Des_Verificacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dt_Cadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dt_Nascimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dt_Contratacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dt_Inativo { get; set; }

        public byte? Bol_Bloqueado { get; set; }

        public byte? Bol_Ativo { get; set; }

        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_grupo tb_grupo { get; set; }

        public virtual tb_perfil tb_perfil { get; set; }
    }
}
