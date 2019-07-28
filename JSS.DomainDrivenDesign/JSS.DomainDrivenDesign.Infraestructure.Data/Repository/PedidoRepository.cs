using JSS.DomainDrivenDesign.Domain.Entities;
using JSS.DomainDrivenDesign.Domain.Interfaces;
using JSS.DomainDrivenDesign.Infraestructure.Data.Context;
using JSS.DomainDrivenDesign.Infraestructure.Data.Context.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace JSS.DomainDrivenDesign.Infraestructure.Data.Repository
{
    public class PedidoRepository : BaseRepository, IPedidoRepository
    {
        public void Salvar(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido BuscarPorId(long pedidoId)
        {
            DbConnection dbConnection = GetBaseDbConnection();

            return null;
        }
    }
}
