using JSS.DomainDrivenDesign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JSS.DomainDrivenDesign.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        void Salvar(Pedido pedido);
        Pedido BuscarPorId(Int64 pedidoId);
    }
}
