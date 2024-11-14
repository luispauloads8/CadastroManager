﻿namespace ClienteProjeto.Domain.Entities;

public class Lancamento : Entity
{
    public int EmpresaId { get; set; }
    public int ContaContabilId { get; set; }
    public int ProdutoServicoId { get; set; }
    public ContaContabil ContaContabil { get; set; }
}
