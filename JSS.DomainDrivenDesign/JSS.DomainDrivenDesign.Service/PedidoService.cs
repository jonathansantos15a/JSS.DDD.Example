using JSS.DomainDrivenDesign.Domain.Entities;
using JSS.DomainDrivenDesign.Domain.Interfaces;
using JSS.DomainDrivenDesign.Infraestructure.Data.Repository;
using System;

namespace JSS.DomainDrivenDesign.Service
{
    public class PedidoService
    {
        public void ConcluirPedido(Int64 pedidoId)
        {
            IPedidoRepository pedidoRepository = new PedidoRepository();

            Pedido pedido = pedidoRepository.BuscarPorId(pedidoId);

            if (pedido == null)
                throw new Exception("O pedido solicitado não foi encontrado na base de dados");

            pedido.Concluir();

            pedidoRepository.Salvar(pedido);
        }
    }
}
