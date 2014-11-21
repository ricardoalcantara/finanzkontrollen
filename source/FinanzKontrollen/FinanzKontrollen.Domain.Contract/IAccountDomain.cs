using FinanzKontrollen.Domain.DataTransferObject;
using System;
using System.Collections.Generic;

namespace FinanzKontrollen.Domain.Contract
{
    public interface IAccountDomain
    {
        IEnumerable<DTOAccount> ListAccounts();
        int InsertAccount(DTOAccount account);
        void DeleteAccount(int id);
    }
}
