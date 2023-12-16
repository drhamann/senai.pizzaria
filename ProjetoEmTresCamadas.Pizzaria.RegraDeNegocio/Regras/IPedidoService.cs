﻿using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Entidades;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Regras;

public interface IPedidoService :
    IAdicionar<Pizza>,
    IObter<Pizza>,
    IAtualizar<Pizza>,
    IDeletar<Pizza>
{
    void FazerPedido(Cliente cliente, Pizza pizza);
    string ObterInformacoesPedidos();
}

