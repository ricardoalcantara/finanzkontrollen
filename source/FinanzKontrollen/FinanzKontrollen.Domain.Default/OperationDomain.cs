using FinanzKontrollen.Domain.Contract;
using FinanzKontrollen.Domain.DataTransferObject;
using FinanzKontrollen.Repository.Contract;
using FinanzKontrollen.Repository.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanzKontrollen.Infrastructure.MapperExtension;

namespace FinanzKontrollen.Domain.Default
{
    public class OperationDomain : IOperationDomain
    {
        private IOperationRepository OperationRepository;

        public OperationDomain()
        {
            this.OperationRepository = new OperationRepository();
        }

        public int InsertOperation(DTOOperation Operation)
        {
            int[] operationValidType = { 1, 2, 3 };

            if (operationValidType.All(x => x != Operation.TypeId))
            {
                throw new ApplicationException("Invalid Operation type");
            }

            if (string.IsNullOrWhiteSpace(Operation.Name))
            {
                throw new ApplicationException("Invalid Operation name");
            }

            return this.OperationRepository.InsertOperation(Operation.ToOperation());
        }
    }
}
