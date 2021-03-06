﻿using ProjectDDD.Application.Interface;
using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base (produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> buscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
