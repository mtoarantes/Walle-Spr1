namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_excecao_url")]
    public partial class tb_excecao_url
    {
        [Key]
        public int Cod_Excecao_url { get; set; }

        [StringLength(100)]
        public string Des_Nome { get; set; }
    }
}
