using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FinanzKontrollen.Repository.Default
{
    public abstract class RepositoryBase
    {
        private RepositoryConnection conn;

        internal RepositoryConnection Conn
        {
            get
            {
                return this.conn;
            }
            set
            {
                this.conn = value;
            }
        }

        public RepositoryBase()
        {
            this.conn = new RepositoryConnection();
        }

        public RepositoryBase(RepositoryConnection conn)
        {
            this.conn = conn;
        }

        public int LastInsertId()
        {
            return this.conn.Connection.Query<int>("SELECT LAST_INSERT_ID();").First();
        }
    }
}
