using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PonteDouradaM2_v2.Models;

namespace PonteDouradaM2_v2.Context;

public partial class SessaoXContext : DbContext
{
    public SessaoXContext()
    {
    }

    public SessaoXContext(DbContextOptions<SessaoXContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Atendimento> Atendimentos { get; set; }

    public virtual DbSet<AtendimentoProduto> AtendimentoProdutos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Endereco> Enderecos { get; set; }

    public virtual DbSet<Fornecedor> Fornecedors { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<ProdutoSolicitacao> ProdutoSolicitacaos { get; set; }

    public virtual DbSet<Profissional> Profissionals { get; set; }

    public virtual DbSet<Servico> Servicos { get; set; }

    public virtual DbSet<Solicitacao> Solicitacaos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=SessaoX;User Id=sa;Password=sql;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Atendimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atendime__3214EC0746D1D452");

            entity.ToTable("Atendimento");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DataAgendada).HasColumnType("datetime");
            entity.Property(e => e.Observacoes).HasColumnType("text");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Cliente).WithMany(p => p.Atendimentos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atendimen__Clien__59FA5E80");

            entity.HasOne(d => d.Profissional).WithMany(p => p.Atendimentos)
                .HasForeignKey(d => d.ProfissionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atendimen__Profi__5AEE82B9");

            entity.HasOne(d => d.Servico).WithMany(p => p.Atendimentos)
                .HasForeignKey(d => d.ServicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atendimen__Servi__5BE2A6F2");
        });

        modelBuilder.Entity<AtendimentoProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Atendime__3214EC07DCC4354B");

            entity.ToTable("AtendimentoProduto");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Atendimento).WithMany(p => p.AtendimentoProdutos)
                .HasForeignKey(d => d.AtendimentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atendimen__Atend__5EBF139D");

            entity.HasOne(d => d.Produto).WithMany(p => p.AtendimentoProdutos)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atendimen__Produ__5FB337D6");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cliente__3214EC07C7C7C8A4");

            entity.ToTable("Cliente");

            entity.HasIndex(e => e.PessoaId, "UQ__Cliente__2F5F55D369AA5252").IsUnique();

            entity.HasIndex(e => e.Cpf, "UQ__Cliente__C1F89731D56AF311").IsUnique();

            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CPF");

            entity.HasOne(d => d.Pessoa).WithOne(p => p.Cliente)
                .HasForeignKey<Cliente>(d => d.PessoaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cliente__PessoaI__3F466844");

            entity.HasOne(d => d.Responsavel).WithMany(p => p.InverseResponsavel)
                .HasForeignKey(d => d.ResponsavelId)
                .HasConstraintName("FK__Cliente__Respons__403A8C7D");
        });

        modelBuilder.Entity<Endereco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Endereco__3214EC077A418250");

            entity.ToTable("Endereco");

            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cep)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CEP");
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Logradouro)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TipoEndereco)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Pessoa).WithMany(p => p.Enderecos)
                .HasForeignKey(d => d.PessoaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Endereco__Pessoa__3A81B327");
        });

        modelBuilder.Entity<Fornecedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Forneced__3214EC072F8BC8DF");

            entity.ToTable("Fornecedor");

            entity.HasIndex(e => e.PessoaId, "UQ__Forneced__2F5F55D314E7F936").IsUnique();

            entity.HasIndex(e => e.Cnpj, "UQ__Forneced__AA57D6B4AC23B9FF").IsUnique();

            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CNPJ");
            entity.Property(e => e.RazaoSocial)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Pessoa).WithOne(p => p.Fornecedor)
                .HasForeignKey<Fornecedor>(d => d.PessoaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Fornecedo__Pesso__49C3F6B7");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pessoa__3214EC078785D791");

            entity.ToTable("Pessoa");

            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Produto__3214EC0725469F19");

            entity.ToTable("Produto");

            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Fornecedor).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.FornecedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Produto__Fornece__4D94879B");
        });

        modelBuilder.Entity<ProdutoSolicitacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProdutoS__3214EC073C4F35A2");

            entity.ToTable("ProdutoSolicitacao");

            entity.HasOne(d => d.Produto).WithMany(p => p.ProdutoSolicitacaos)
                .HasForeignKey(d => d.ProdutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProdutoSo__Produ__534D60F1");

            entity.HasOne(d => d.Solicitcao).WithMany(p => p.ProdutoSolicitacaos)
                .HasForeignKey(d => d.SolicitcaoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProdutoSo__Solic__5441852A");
        });

        modelBuilder.Entity<Profissional>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Profissi__3214EC07323AF0E0");

            entity.ToTable("Profissional");

            entity.HasIndex(e => e.PessoaId, "UQ__Profissi__2F5F55D391D0CDB5").IsUnique();

            entity.HasIndex(e => e.Cpf, "UQ__Profissi__C1F89731B0817019").IsUnique();

            entity.Property(e => e.ConselhoRegistro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CPF");
            entity.Property(e => e.TipoProfissional)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Pessoa).WithOne(p => p.Profissional)
                .HasForeignKey<Profissional>(d => d.PessoaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Profissio__Pesso__44FF419A");
        });

        modelBuilder.Entity<Servico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servico__3214EC07729CF8C4");

            entity.ToTable("Servico");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descricao).HasColumnType("text");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrecoBase).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Solicitacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Solicita__3214EC071D48CDB2");

            entity.ToTable("Solicitacao");

            entity.Property(e => e.Descricao)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Cliente).WithMany(p => p.Solicitacaos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Solicitac__Clien__5070F446");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC07308F4D6B");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.PessoaId, "UQ__Usuario__2F5F55D3B4D8551A").IsUnique();

            entity.HasIndex(e => e.Login, "UQ__Usuario__5E55825B7E33D592").IsUnique();

            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Perfil)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SenhaHash)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Pessoa).WithOne(p => p.Usuario)
                .HasForeignKey<Usuario>(d => d.PessoaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__PessoaI__656C112C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
