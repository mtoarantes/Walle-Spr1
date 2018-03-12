namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_Situacao")]
    public partial class tb_Situacao
    {
        [Key]
        public int Cod_Situacao { get; set; }

        [StringLength(45)]
        public string Des_Nome { get; set; }
    }
}
