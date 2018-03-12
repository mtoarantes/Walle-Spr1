namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_abono")]
    public partial class tb_abono
    {
        [Key]
        public int Cod_Abono { get; set; }

        public int Cod_Abono_Tipo { get; set; }

        public int Cod_Coleta { get; set; }

        public int Cod_Usuario_Admin { get; set; }

        public virtual tb_coleta tb_coleta { get; set; }

        public virtual tb_abono_tipo tb_abono_tipo { get; set; }

        public virtual tb_cliente_usuario_admin tb_cliente_usuario_admin { get; set; }
    }
}
