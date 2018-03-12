namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_ftp")]
    public partial class tb_ftp
    {
        [Key]
        public int Cod_FTP { get; set; }

        [StringLength(50)]
        public string Des_Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Des_Caminho { get; set; }

        [StringLength(50)]
        public string Des_User { get; set; }

        [StringLength(50)]
        public string Des_Senha { get; set; }
    }
}
