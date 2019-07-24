using JSS.DomainDrivenDesign.Domain.Entities;
using JSS.DomainDrivenDesign.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JSS.DomainDrivenDesign.Infraestructure.Data.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        public void Salvar(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        Pedido IPedidoRepository.BuscarPorId(long pedidoId)
        {
            throw new NotImplementedException();
        }
    }
}
