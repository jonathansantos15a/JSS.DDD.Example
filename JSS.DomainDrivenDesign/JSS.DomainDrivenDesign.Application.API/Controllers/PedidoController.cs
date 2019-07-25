using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSS.DomainDrivenDesign.Domain.Entities;
using JSS.DomainDrivenDesign.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JSS.DomainDrivenDesign.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet("consultarPorId/{id}")]
        public ActionResult<Pedido> BuscarPorId(int pedidoId)
        {
            Pedido pedido = _pedidoService.BuscarPorId(pedidoId);

            return pedido;
        }

        [HttpPost("concluirPedido")]
        public void Concluir([FromBody] int pedidoId)
        {
            _pedidoService.ConcluirPedido(pedidoId);
        }
}
}