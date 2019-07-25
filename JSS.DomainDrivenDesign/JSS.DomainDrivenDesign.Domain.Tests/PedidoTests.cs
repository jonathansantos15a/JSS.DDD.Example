using JSS.DomainDrivenDesign.Domain.Entities;
using JSS.DomainDrivenDesign.Domain.Enums;
using System;
using Xunit;

namespace JSS.DomainDrivenDesign.Tests.DomainTests
{
    public class PedidoTests
    {
        [Fact]
        public void Pedido_DevePermitirConcluirUmPedidoCom xito()
        {
            Pedido pedido = new Pedido();

            Assert.Equal(PedidoStatus.Criado, pedido.Status);

            pedido.Concluir();

            Assert.Equal(PedidoStatus.ConcluÌdo, pedido.Status);
        }

        [Fact]
        public void Pedido_DevePermitirCancelarUmPedidoCom xito()
        {
            Pedido pedido = new Pedido();

            Assert.Equal(PedidoStatus.Criado, pedido.Status);

            pedido.Cancelar();

            Assert.Equal(PedidoStatus.Cancelado, pedido.Status);
        }
    }
}
