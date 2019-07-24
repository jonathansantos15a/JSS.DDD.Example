using JSS.DomainDrivenDesign.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JSS.DomainDrivenDesign.Domain.Entities
{
    public class Pedido : EntidadeBase
    {

        public Pedido() { }

        public String NúmeroSequencial { get; private set; }

        public Decimal ValorTotal { get; private set; }

        public PedidoStatus Status { get; private set; }

        public void Concluir()
        {
            this.Status = PedidoStatus.Concluído;
        }

        public void CancelarPedido()
        {
            this.Status = PedidoStatus.Cancelado;
        }
    }
}
