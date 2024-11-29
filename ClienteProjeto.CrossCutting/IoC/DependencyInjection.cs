﻿using ClienteProjeto.Domain.Interfaces;
using ClienteProjeto.Infrastructure.Context;
using ClienteProjeto.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClienteProjeto.CrossCutting.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 29))));

        services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        services.AddScoped<ICidadeRepository, CidadeRepository>();
        services.AddScoped<IClienteRepository, ClienteRepository>();
        services.AddScoped<IContaContabilRepository, ContaContabilRepository>();
        services.AddScoped<IEmpresaRepository, EmpresaRepository>();
        services.AddScoped<IFornecedorRepository, FornecedorRepository>();
        services.AddScoped<IGrupoContaRepository, GrupoContaRepository>();
        services.AddScoped<ILancamentoRepository, LancamentoRepository>();
        services.AddScoped<IProdutoServicoRepository, ProdutoServicoRepository>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        return services;
    }
}