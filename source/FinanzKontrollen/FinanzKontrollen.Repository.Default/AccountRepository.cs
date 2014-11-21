using FinanzKontrollen.Repository.Contract;
using FinanzKontrollen.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FinanzKontrollen.Repository.Default
{
    public class AccountRepository : RepositoryBase, IAccountRepository
    {
        public IEnumerable<Account> ListAccounts()
        {
            this.Conn.Open();

            IEnumerable<Account> empresas = this.Conn.Connection.Query<Account>(AccountRepository.GET_ALL_ACCOUNTS);

            this.Conn.Close();

            return empresas;
        }

        public int InsertAccount(Account account)
        {
            this.Conn.Open();

            this.Conn.Connection.Execute(AccountRepository.INSERT_ACCOUNT, account);
            int Id = this.LastInsertId();

            this.Conn.Close();

            return Id;
        }

        public void DeleteAccount(int id)
        {
            this.Conn.Open();

            int totalRows = this.Conn.Connection.Execute(AccountRepository.DELETE_ACCOUNT, new { Id = id });

            this.Conn.Close();
        }

        private const string GET_ALL_ACCOUNTS = @"SELECT account.Id,
    account.Name
FROM finanzkontrollen.account
";
        private const string INSERT_ACCOUNT = @"INSERT INTO finanzkontrollen.account
(Id,
Name)
VALUES
(@Id,
 @Name);
";
        private const string DELETE_ACCOUNT = @"DELETE FROM finanzkontrollen.account
WHERE account.Id = @Id;";
    }
}
