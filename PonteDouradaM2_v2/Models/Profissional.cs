using System;
using System.Collections.Generic;

namespace PonteDouradaM2_v2.Models;

public partial class Profissional
{
    public int Id { get; set; }

    public int PessoaId { get; set; }

    public string TipoProfissional { get; set; } = null!;

    public string? ConselhoRegistro { get; set; }

    public string Cpf { get; set; } = null!;

    public virtual ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();

    public virtual Pessoa Pessoa { get; set; } = null!;
}
