﻿using AutoMapper;
using ClienteProjeto.Application.DTOs;
using ClienteProjeto.Application.Interfaces;
using ClienteProjeto.Domain.Interfaces;

namespace ClienteProjeto.Application.Services;

public class ProdutoServicoService : IProdutoServicoService
{
    private IProdutoServicoRepository _produtoServicoRepository;
    private readonly IMapper _mapper;

    public ProdutoServicoService(IProdutoServicoRepository produtoServicoRepository, IMapper mapper)
    {
        _produtoServicoRepository = produtoServicoRepository;
        _mapper = mapper;
    }

    public Task Add(ProdutoServicoDTO produtoServicoDTO)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int? id)
    {
        throw new NotImplementedException();
    }

    public Task<ProdutoServicoDTO> GetById(int? id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProdutoServicoDTO>> GetProdutosServicos()
    {
        throw new NotImplementedException();
    }

    public Task Update(ProdutoServicoDTO produto)
    {
        throw new NotImplementedException();
    }
}
