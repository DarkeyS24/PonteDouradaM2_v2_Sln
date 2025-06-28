using System;
using System.Collections.Generic;

namespace PonteDouradaM2_v2.Models;

public partial class Solicitacao
{
    public int Id { get; set; }

    public DateOnly Validade { get; set; }

    public DateOnly DataCadastro { get; set; }

    public int ClienteId { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<ProdutoSolicitacao> ProdutoSolicitacaos { get; set; } = new List<ProdutoSolicitacao>();
}
