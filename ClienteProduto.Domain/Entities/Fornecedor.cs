﻿namespace ClienteProjeto.Domain.Entities;

public class Fornecedor : Entity
{

    public string Descricao { get; set; }
    public string CNPJ { get; set; }
    public string Telefone { get; set; }
    public string Endereco { get; set; }
    public string CEP { get; set; }
    public string Observacao { get; set; }
    public int CidadeId { get; set; }
    public int EmpresaId { get; set; }
    public string Email { get; set; }
    public EnumSexo Sexo { get; set; }
    public EnumEstadoCivil EstadoCivil { get; set; }
    public Cidade Cidade { get; set; }
    public Empresa Empresa { get; set; }
}
