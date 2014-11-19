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
    public class OperationRepository : RepositoryBase, IOperationRepository
    {
        public int InsertOperation(Operation operation)
        {
            this.Conn.Open();

            this.Conn.Connection.Execute(OperationRepository.INSERT_OPERATION, operation);
            int Id = this.LastInsertId();

            this.Conn.Close();

            return Id;
        }

        private const string INSERT_OPERATION = @"INSERT INTO finanzkontrollen.operation
(Id,
Name,
Description,
PayDate,
TypeId,
Ammount,
AccountId)
VALUES
(@Id,
@Name,
@Description,
@PayDate,
@TypeId,
@Ammount,
@AccountId);
";
    }
}
