namespace Walle.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("renew_tb_coleta")]
    public partial class tb_coleta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_coleta()
        {
            tb_abono = new HashSet<tb_abono>();
        }

        [Key]
        public int Cod_Coleta { get; set; }

        public int Cod_Cliente { get; set; }

        [StringLength(100)]
        public string Des_Usuario_Rede { get; set; }

        [StringLength(300)]
        public string Des_Processo { get; set; }

        public int? Cod_Categoria_App { get; set; }

        [StringLength(500)]
        public string Des_Nome { get; set; }

        public int? Cod_Categoria_Page { get; set; }

        [Required]
        [StringLength(500)]
        public string Des_URL { get; set; }

        public int? Cod_Categoria_url { get; set; }

        [StringLength(700)]
        public string Des_Local { get; set; }

        public DateTime? Date_Hora_Inicio { get; set; }

        public DateTime? Date_Hora_Fim { get; set; }

        public int? Int_Tempo { get; set; }

        [Required]
        [StringLength(100)]
        public string Des_Identificador_PC { get; set; }

        [Required]
        [StringLength(250)]
        public string Des_Chave_Processo { get; set; }

        public int? Cod_Cliente_Usuario { get; set; }

        [StringLength(45)]
        public string Des_Versao { get; set; }

        [StringLength(45)]
        public string Des_Rastrear { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_abono> tb_abono { get; set; }

        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_cliente_categoria_page tb_cliente_categoria_page { get; set; }

        public virtual tb_cliente_categoria_url tb_cliente_categoria_url { get; set; }

        public virtual tb_cliente_usuario tb_cliente_usuario { get; set; }
    }
}
