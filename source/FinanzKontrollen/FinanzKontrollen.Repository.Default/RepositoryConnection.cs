using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollen.Repository.Default
{
    public class RepositoryConnection
    {
        private MySqlConnection mySqlConnection;
        private MySqlTransaction mySqlTransaction;

        internal MySqlConnection Connection
        {
            get
            {
                return this.mySqlConnection;
            }
            set
            {
                this.mySqlConnection = value;
            }
        }

        public RepositoryConnection()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["finanzkontrollen-mysql"].ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("Please configure the connectionstring finanzkontrollen-mysql");
            }

            this.mySqlConnection = new MySqlConnection(connectionString);
        }

        public void Open()
        {
            if (this.mySqlConnection.State == System.Data.ConnectionState.Closed)
            {
                this.mySqlConnection.Open();
            }
        }

        public void Close()
        {
            if (this.mySqlTransaction == null)
            {
                this.mySqlConnection.Close();
            }
        }

        public void BeginTransaction()
        {
            this.mySqlTransaction = this.Connection.BeginTransaction();
        }

        public void Commit()
        {
            this.mySqlTransaction.Commit();
            this.mySqlTransaction.Dispose();
            this.mySqlTransaction = null;
        }

        public void RollBack()
        {

        }
    }
}
