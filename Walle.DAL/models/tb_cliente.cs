namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_cliente")]
    public partial class tb_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente()
        {
            tb_area = new HashSet<tb_area>();
            tb_cliente_usuario = new HashSet<tb_cliente_usuario>();
            tb_usuario = new HashSet<tb_usuario>();
            tb_coleta = new HashSet<tb_coleta>();
            tb_cliente_host_licenca = new HashSet<tb_cliente_host_licenca>();
            tb_log_acoes = new HashSet<tb_log_acoes>();
            tb_log_send = new HashSet<tb_log_send>();
            tb_cliente_pc_on = new HashSet<tb_cliente_pc_on>();
        }

        [Key]
        public int Cod_Cliente { get; set; }

        [StringLength(250)]
        public string Des_Nome { get; set; }

        [StringLength(500)]
        public string Des_Razao_Social { get; set; }

        [StringLength(25)]
        public string Des_CNPJ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Data_Cadastro { get; set; }

        [Required]
        [StringLength(100)]
        public string Des_Chave_Criptografia { get; set; }

        [Required]
        [StringLength(34)]
        public string Des_Product_Key { get; set; }

        public int Int_Qtde_Licencas { get; set; }

        public int? Int_Qtde_OnDemand { get; set; }

        public int? Num_Matriz { get; set; }

        [StringLength(18)]
        public string Des_Inscricao_Estadual { get; set; }

        public bool? Bol_Ativo { get; set; }

        [StringLength(255)]
        public string Des_Endereco { get; set; }

        [StringLength(45)]
        public string Des_Complemento { get; set; }

        [StringLength(45)]
        public string Des_Bairro { get; set; }

        [StringLength(10)]
        public string Des_Numero { get; set; }

        [StringLength(10)]
        public string Des_Cep { get; set; }

        [StringLength(45)]
        public string Des_Estado { get; set; }

        [StringLength(255)]
        public string Des_Cidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_area> tb_area { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_usuario> tb_cliente_usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_usuario> tb_usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_coleta> tb_coleta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_host_licenca> tb_cliente_host_licenca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_acoes> tb_log_acoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_log_send> tb_log_send { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cliente_pc_on> tb_cliente_pc_on { get; set; }
    }
}
