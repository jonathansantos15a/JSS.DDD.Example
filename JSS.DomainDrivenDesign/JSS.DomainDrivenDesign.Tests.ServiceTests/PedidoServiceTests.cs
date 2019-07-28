using JSS.DomainDrivenDesign.Domain.Entities;
using JSS.DomainDrivenDesign.Domain.Enums;
using JSS.DomainDrivenDesign.Service.Interfaces;
using JSS.DomainDrivenDesign.Service.Services;
using System;
using Xunit;

namespace JSS.DomainDrivenDesign.Tests.ServiceTests
{
    public class PedidoServiceTests
    {
        [Fact]
        public void PedidoService_DevePermitirConcluirUmPedidoComÊxito()
        {
            IPedidoService pedidoService = new PedidoService();

            Pedido pedido = pedidoService.BuscarPorId(1);

            Assert.Equal(PedidoStatus.Criado, pedido.Status);

            pedidoService.Concluir(1);

            pedido = pedidoService.BuscarPorId(1);

            Assert.Equal(PedidoStatus.Concluído, pedido.Status);
        }
    }
}
