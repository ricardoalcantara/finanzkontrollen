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
    public class AccountDomain : IAccountDomain
    {
        private IAccountRepository accountRepository;

        public AccountDomain()
        {
            this.accountRepository = new AccountRepository();
        }

        public IEnumerable<DTOAccount> ListAccounts()
        {
            return this.accountRepository.ListAccounts().ToListDtoAccount();
        }

        public int InsertAccount(DTOAccount account)
        {
            if (string.IsNullOrWhiteSpace(account.Name))
            {
                throw new ApplicationException("Invalid account name");
            }

            return this.accountRepository.InsertAccount(account.ToAccount());
        }
        
        public void DeleteAccount(int id)
        {
            this.accountRepository.DeleteAccount(id);
        }
    }
}
