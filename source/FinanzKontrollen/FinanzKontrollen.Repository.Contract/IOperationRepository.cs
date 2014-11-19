using FinanzKontrollen.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollen.Repository.Contract
{
    public interface IOperationRepository
    {
        int InsertOperation(Operation operation);
    }
}
