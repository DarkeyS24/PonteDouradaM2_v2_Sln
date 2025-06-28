using System;
using System.Collections.Generic;

namespace PonteDouradaM2_v2.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public int PessoaId { get; set; }

    public DateOnly DataNascimento { get; set; }

    public string Cpf { get; set; } = null!;

    public int? ResponsavelId { get; set; }

    public virtual ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();

    public virtual ICollection<Cliente> InverseResponsavel { get; set; } = new List<Cliente>();

    public virtual Pessoa Pessoa { get; set; } = null!;

    public virtual Cliente? Responsavel { get; set; }

    public virtual ICollection<Solicitacao> Solicitacaos { get; set; } = new List<Solicitacao>();
}
