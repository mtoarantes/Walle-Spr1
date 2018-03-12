namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_log_send")]
    public partial class tb_log_send
    {
        [Key]
        public int cod_log_send { get; set; }

        [StringLength(45)]
        public string des_id_processador { get; set; }

        [StringLength(25)]
        public string des_data_hora { get; set; }

        [StringLength(16)]
        public string des_ip { get; set; }

        public int? cod_cliente { get; set; }

        [StringLength(45)]
        public string des_nome_pc { get; set; }

        public virtual tb_cliente tb_cliente { get; set; }
    }
}
