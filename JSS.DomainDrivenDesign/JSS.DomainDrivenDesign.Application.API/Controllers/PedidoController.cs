using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JSS.DomainDrivenDesign.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpGet("consultarPorId/{id}")]
        public ActionResult<string> BuscarPorId(int pedidoId)
        {
            return "value";
        }


        [HttpPost("concluirPedido")]
        public void ConcluirPedido([FromBody] string value)
        {
        }
}
}