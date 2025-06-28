using System;
using System.Collections.Generic;

namespace PonteDouradaM2_v2.Models;

public partial class Endereco
{
    public int Id { get; set; }

    public int PessoaId { get; set; }

    public string? Logradouro { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Estado { get; set; }

    public string? Cep { get; set; }

    public string? TipoEndereco { get; set; }

    public virtual Pessoa Pessoa { get; set; } = null!;
}
