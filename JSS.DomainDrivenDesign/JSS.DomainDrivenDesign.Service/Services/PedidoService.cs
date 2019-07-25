using JSS.DomainDrivenDesign.Domain.Entities;
using JSS.DomainDrivenDesign.Domain.Interfaces;
using JSS.DomainDrivenDesign.Infraestructure.Data.Repository;
using JSS.DomainDrivenDesign.Service.Interfaces;
using System;

namespace JSS.DomainDrivenDesign.Service.Services
{
    public class PedidoService: IPedidoService
    {
        #region Comportamentos

        public void ConcluirPedido(Int64 pedidoId)
        {
            IPedidoRepository pedidoRepository = new PedidoRepository();

            Pedido pedido = _buscarPorId(pedidoId);

            pedido.Concluir();

            pedidoRepository.Salvar(pedido);
        }

        public Pedido BuscarPorId(Int64 pedidoId)
        {
            return _buscarPorId(pedidoId);
        }

        #endregion Comportamentos

        #region Métodos privados

        private Pedido _buscarPorId(Int64 pedidoId)
        {
            IPedidoRepository pedidoRepository = new PedidoRepository();

            Pedido pedido = pedidoRepository.BuscarPorId(pedidoId);

            if (pedido == null)
                throw new Exception("O pedido solicitado não foi encontrado na base de dados");

            return pedido;
        }

        #endregion Métodos privados
    }
}
