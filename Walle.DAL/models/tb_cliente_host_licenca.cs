namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_cliente_host_licenca")]
    public partial class tb_cliente_host_licenca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente_host_licenca()
        {
            tb_cliente_pc_on = new HashSet<tb_cliente_pc_on>();
        }

        [Key]
        public int Cod_cliente_host_licenca { get; set; }

        public int Cod_Cliente { get; set; }

        [StringLength(100)]
        public string Des_Nome_Maquina { get; set; }

        [StringLength(30)]
        public string Des_IP_Register { get; set; }

        public bool? Bol_Ativo { get; set; }

        public bool? Bol_Dinamico { get; set; }

        public bool? Bol_Status { get; set; }

        [StringLength(45)]
        public string Des_DataHoraLogin { get; set; }

        [StringLength(80)]
        public string Des_FTP { get; set; }

        [StringLength(45)]
        public string Des_Host_Name { get; set; }

        [StringLength(15)]
        public string Des_IP { get; set; }

        public virtual tb_cliente tb_cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_pc_on> tb_cliente_pc_on { get; set; }
    }
}
