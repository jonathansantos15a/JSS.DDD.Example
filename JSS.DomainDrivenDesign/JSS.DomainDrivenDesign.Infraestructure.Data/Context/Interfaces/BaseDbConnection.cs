using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace JSS.DomainDrivenDesign.Infraestructure.Data.Context.Interfaces
{
    public class BaseDbConnection : DbConnection
    {
        private static DbConnection _dbConnection;

        public DbConnection GetInstance
        {
            get
            {
                if (_dbConnection == null)
                    _dbConnection = new SqlConnection();
                else
                    return _dbConnection;

                return _dbConnection;
            }

            private set { }
        }

        public override string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Database => throw new NotImplementedException();

        public override string DataSource => throw new NotImplementedException();

        public override string ServerVersion => throw new NotImplementedException();

        public override ConnectionState State => throw new NotImplementedException();

        public override void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override void Open()
        {
            throw new NotImplementedException();
        }

        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        protected override DbCommand CreateDbCommand()
        {
            throw new NotImplementedException();
        }
    }
}
