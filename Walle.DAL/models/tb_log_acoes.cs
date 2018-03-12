namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_log_acoes")]
    public partial class tb_log_acoes
    {
        [Key]
        public int Cod_Log_Acoes { get; set; }

        public int? Cod_Cliente { get; set; }

        public int? Cod_Usuario { get; set; }

        [StringLength(45)]
        public string Des_Data_Ação { get; set; }

        public int? Cod_Tipo_log { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string Des_Descricao { get; set; }

        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_cliente_usuario tb_cliente_usuario { get; set; }

        public virtual tb_log_acoes_tipo tb_log_acoes_tipo { get; set; }
    }
}
