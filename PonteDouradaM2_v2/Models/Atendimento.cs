using System;
using System.Collections.Generic;

namespace PonteDouradaM2_v2.Models;

public partial class Atendimento
{
    public int Id { get; set; }

    public int ClienteId { get; set; }

    public int ProfissionalId { get; set; }

    public int ServicoId { get; set; }

    public DateTime DataAgendada { get; set; }

    public string Status { get; set; } = null!;

    public string? Observacoes { get; set; }

    public virtual ICollection<AtendimentoProduto> AtendimentoProdutos { get; set; } = new List<AtendimentoProduto>();

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual Profissional Profissional { get; set; } = null!;

    public virtual Servico Servico { get; set; } = null!;
}
