using JSS.DomainDrivenDesign.Infraestructure.Data.Context.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace JSS.DomainDrivenDesign.Infraestructure.Data.Context
{
    public abstract class BaseRepository
    {
        public DbConnection GetBaseDbConnection()
        {
            return new BaseDbConnection().GetInstance;
        }
        
        public void Commit(DbTransaction dbTransaction)
        {
            dbTransaction.Commit();
        }

        public void Rollback(DbTransaction dbTransaction)
        {
            dbTransaction.Rollback();
        }
    }
}
