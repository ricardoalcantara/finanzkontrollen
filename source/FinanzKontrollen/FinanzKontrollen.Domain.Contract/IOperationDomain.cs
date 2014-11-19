using FinanzKontrollen.Domain.DataTransferObject;
using System;
using System.Collections.Generic;

namespace FinanzKontrollen.Domain.Contract
{
    public interface IOperationDomain
    {
        int InsertOperation(DTOOperation operation);
    }
}
