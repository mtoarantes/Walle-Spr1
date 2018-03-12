namespace Walle.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbWalleContext : DbContext
    {
        public DbWalleContext()
            : base("name=DbWalleContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<tb_abono> tb_abono { get; set; }
        public virtual DbSet<tb_abono_tipo> tb_abono_tipo { get; set; }
        public virtual DbSet<tb_area> tb_area { get; set; }
        public virtual DbSet<tb_cadastro_cidade> tb_cadastro_cidade { get; set; }
        public virtual DbSet<tb_cadastro_estado> tb_cadastro_estado { get; set; }
        public virtual DbSet<tb_cadastro_pais> tb_cadastro_pais { get; set; }
        public virtual DbSet<tb_categoria> tb_categoria { get; set; }
        public virtual DbSet<tb_cliente> tb_cliente { get; set; }
        public virtual DbSet<tb_cliente_categoria_app> tb_cliente_categoria_app { get; set; }
        public virtual DbSet<tb_cliente_categoria_page> tb_cliente_categoria_page { get; set; }
        public virtual DbSet<tb_cliente_categoria_url> tb_cliente_categoria_url { get; set; }
        public virtual DbSet<tb_cliente_host_licenca> tb_cliente_host_licenca { get; set; }
        public virtual DbSet<tb_cliente_pc_on> tb_cliente_pc_on { get; set; }
        public virtual DbSet<tb_cliente_usuario> tb_cliente_usuario { get; set; }
        public virtual DbSet<tb_cliente_usuario_admin> tb_cliente_usuario_admin { get; set; }
        public virtual DbSet<tb_coleta> tb_coleta { get; set; }
        public virtual DbSet<tb_excecao_url> tb_excecao_url { get; set; }
        public virtual DbSet<tb_ftp> tb_ftp { get; set; }
        public virtual DbSet<tb_grupo> tb_grupo { get; set; }
        public virtual DbSet<tb_log_acoes> tb_log_acoes { get; set; }
        public virtual DbSet<tb_log_acoes_tipo> tb_log_acoes_tipo { get; set; }
        public virtual DbSet<tb_log_send> tb_log_send { get; set; }
        public virtual DbSet<tb_perfil> tb_perfil { get; set; }
        public virtual DbSet<tb_programa_lista> tb_programa_lista { get; set; }
        public virtual DbSet<tb_programa_tipo> tb_programa_tipo { get; set; }
        public virtual DbSet<tb_Situacao> tb_Situacao { get; set; }
        public virtual DbSet<tb_usuario> tb_usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_abono_tipo>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_abono_tipo>()
                .HasMany(e => e.tb_abono)
                .WithRequired(e => e.tb_abono_tipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_area>()
                .Property(e => e.Des_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cadastro_cidade>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cadastro_estado>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cadastro_estado>()
                .Property(e => e.Des_Uf)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cadastro_pais>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cadastro_pais>()
                .Property(e => e.Des_Sigla)
                .IsUnicode(false);

            modelBuilder.Entity<tb_categoria>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_categoria>()
                .HasMany(e => e.tb_cliente_categoria_app)
                .WithRequired(e => e.tb_categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_categoria>()
                .HasMany(e => e.tb_cliente_categoria_page)
                .WithRequired(e => e.tb_categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_categoria>()
                .HasMany(e => e.tb_cliente_categoria_url)
                .WithRequired(e => e.tb_categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Razao_Social)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Chave_Criptografia)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Product_Key)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Inscricao_Estadual)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Cep)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .Property(e => e.Des_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente>()
                .HasMany(e => e.tb_cliente_usuario)
                .WithRequired(e => e.tb_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_cliente>()
                .HasMany(e => e.tb_usuario)
                .WithRequired(e => e.tb_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_cliente>()
                .HasMany(e => e.tb_coleta)
                .WithRequired(e => e.tb_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_cliente>()
                .HasMany(e => e.tb_cliente_host_licenca)
                .WithRequired(e => e.tb_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_cliente_categoria_app>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_categoria_app>()
                .Property(e => e.Dt_Vigencia_Inicio)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_categoria_app>()
                .Property(e => e.Dt_Vigencia_Fim)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_categoria_app>()
                .HasMany(e => e.tb_cliente_categoria_page)
                .WithRequired(e => e.tb_cliente_categoria_app)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_cliente_categoria_app>()
                .HasMany(e => e.tb_cliente_categoria_url)
                .WithRequired(e => e.tb_cliente_categoria_app)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_cliente_categoria_page>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_categoria_page>()
                .Property(e => e.Dt_Virgencia_Inicio)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_categoria_page>()
                .Property(e => e.Dt_Virgencia_Fim)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_categoria_url>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_categoria_url>()
                .Property(e => e.Dt_Virgencia_Inicio)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_categoria_url>()
                .Property(e => e.Dt_Virgencia_Fim)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_host_licenca>()
                .Property(e => e.Des_Nome_Maquina)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_host_licenca>()
                .Property(e => e.Des_IP_Register)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_host_licenca>()
                .Property(e => e.Des_DataHoraLogin)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_host_licenca>()
                .Property(e => e.Des_FTP)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_host_licenca>()
                .Property(e => e.Des_Host_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_host_licenca>()
                .Property(e => e.Des_IP)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_host_licenca>()
                .HasMany(e => e.tb_cliente_pc_on)
                .WithOptional(e => e.tb_cliente_host_licenca)
                .HasForeignKey(e => e.cod_host_licenca);

            modelBuilder.Entity<tb_cliente_pc_on>()
                .Property(e => e.des_id_processador)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_pc_on>()
                .Property(e => e.des_data_hora)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_pc_on>()
                .Property(e => e.des_ip)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_pc_on>()
                .Property(e => e.des_nome_pc)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario>()
                .Property(e => e.Des_Nome_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario>()
                .Property(e => e.Des_Usuario_Rede)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario>()
                .Property(e => e.Des_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario>()
                .Property(e => e.Des_Matricula)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario>()
                .Property(e => e.Dt_Cadastro)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario>()
                .Property(e => e.Dt_Nascimento)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario>()
                .Property(e => e.Dt_Contratacao)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario>()
                .Property(e => e.Dt_Inativo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario>()
                .HasMany(e => e.tb_log_acoes)
                .WithOptional(e => e.tb_cliente_usuario)
                .HasForeignKey(e => e.Cod_Usuario);

            modelBuilder.Entity<tb_cliente_usuario_admin>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario_admin>()
                .Property(e => e.Des_Nome_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario_admin>()
                .Property(e => e.Des_Email_Login)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario_admin>()
                .Property(e => e.Des_Password)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario_admin>()
                .Property(e => e.Des_Verificacao)
                .IsUnicode(false);

            modelBuilder.Entity<tb_cliente_usuario_admin>()
                .HasMany(e => e.tb_abono)
                .WithRequired(e => e.tb_cliente_usuario_admin)
                .HasForeignKey(e => e.Cod_Usuario_Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_coleta>()
                .Property(e => e.Des_Usuario_Rede)
                .IsUnicode(false);

            modelBuilder.Entity<tb_coleta>()
                .Property(e => e.Des_Processo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_coleta>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_coleta>()
                .Property(e => e.Des_URL)
                .IsUnicode(false);

            modelBuilder.Entity<tb_coleta>()
                .Property(e => e.Des_Local)
                .IsUnicode(false);

            modelBuilder.Entity<tb_coleta>()
                .Property(e => e.Des_Identificador_PC)
                .IsUnicode(false);

            modelBuilder.Entity<tb_coleta>()
                .Property(e => e.Des_Chave_Processo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_coleta>()
                .Property(e => e.Des_Versao)
                .IsUnicode(false);

            modelBuilder.Entity<tb_coleta>()
                .Property(e => e.Des_Rastrear)
                .IsUnicode(false);

            modelBuilder.Entity<tb_coleta>()
                .HasMany(e => e.tb_abono)
                .WithRequired(e => e.tb_coleta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_excecao_url>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_ftp>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_ftp>()
                .Property(e => e.Des_Caminho)
                .IsUnicode(false);

            modelBuilder.Entity<tb_ftp>()
                .Property(e => e.Des_User)
                .IsUnicode(false);

            modelBuilder.Entity<tb_ftp>()
                .Property(e => e.Des_Senha)
                .IsUnicode(false);

            modelBuilder.Entity<tb_grupo>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_grupo>()
                .Property(e => e.Dt_Cadastro)
                .IsUnicode(false);

            modelBuilder.Entity<tb_grupo>()
                .Property(e => e.Dt_Inativo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_grupo>()
                .HasMany(e => e.tb_cliente_categoria_app)
                .WithRequired(e => e.tb_grupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_grupo>()
                .HasMany(e => e.tb_cliente_usuario)
                .WithRequired(e => e.tb_grupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_grupo>()
                .HasMany(e => e.tb_usuario)
                .WithRequired(e => e.tb_grupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_log_acoes>()
                .Property(e => e.Des_Data_Ação)
                .IsUnicode(false);

            modelBuilder.Entity<tb_log_acoes>()
                .Property(e => e.Des_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<tb_log_acoes_tipo>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_log_acoes_tipo>()
                .HasMany(e => e.tb_log_acoes)
                .WithOptional(e => e.tb_log_acoes_tipo)
                .HasForeignKey(e => e.Cod_Tipo_log);

            modelBuilder.Entity<tb_log_send>()
                .Property(e => e.des_id_processador)
                .IsUnicode(false);

            modelBuilder.Entity<tb_log_send>()
                .Property(e => e.des_data_hora)
                .IsUnicode(false);

            modelBuilder.Entity<tb_log_send>()
                .Property(e => e.des_ip)
                .IsUnicode(false);


        modelBuilder.Entity<tb_log_send>()
                .Property(e => e.des_nome_pc)
                .IsUnicode(false);

            modelBuilder.Entity<tb_perfil>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_perfil>()
                .HasMany(e => e.tb_cliente_usuario_admin)
                .WithRequired(e => e.tb_perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_perfil>()
                .HasMany(e => e.tb_usuario)
                .WithRequired(e => e.tb_perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_programa_lista>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_programa_lista>()
                .Property(e => e.Des_Executavel)
                .IsUnicode(false);

            modelBuilder.Entity<tb_programa_tipo>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_programa_tipo>()
                .HasMany(e => e.tb_programa_lista)
                .WithRequired(e => e.tb_programa_tipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_Situacao>()
                .Property(e => e.Des_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_usuario>()
                .Property(e => e.Des_Pri_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<tb_usuario>()
                .Property(e => e.Des_Nome_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_usuario>()
                .Property(e => e.Des_Usuario_Rede)
                .IsUnicode(false);

            modelBuilder.Entity<tb_usuario>()
                .Property(e => e.Des_Email_Login)
                .IsUnicode(false);

            modelBuilder.Entity<tb_usuario>()
                .Property(e => e.Des_Senha)
                .IsUnicode(false);

            modelBuilder.Entity<tb_usuario>()
                .Property(e => e.Des_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<tb_usuario>()
                .Property(e => e.Des_Matricula)
                .IsUnicode(false);

            modelBuilder.Entity<tb_usuario>()
                .Property(e => e.Des_Verificacao)
                .IsUnicode(false);
        }
    }
}
