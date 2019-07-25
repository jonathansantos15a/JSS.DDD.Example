using JSS.DomainDrivenDesign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JSS.DomainDrivenDesign.Service.Interfaces
{
    public interface IPedidoService
    {
        void ConcluirPedido(Int64 pedidoId);

        Pedido BuscarPorId(Int64 pedidoId);
    }
}
