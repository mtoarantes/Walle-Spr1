namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_cadastro_cidade")]
    public partial class tb_cadastro_cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cod_Cidade { get; set; }

        [StringLength(120)]
        public string Des_Nome { get; set; }

        public int? Cod_Estado { get; set; }

        public virtual tb_cadastro_estado tb_cadastro_estado { get; set; }
    }
}
