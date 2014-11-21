using FinanzKontrollen.Domain.Contract;
using FinanzKontrollen.Domain.DataTransferObject;
using FinanzKontrollen.Domain.Default;
using FinanzKontrollen.Presentation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinanzKontrollen.Presentation.WebApi.Controllers
{
    public class AccountController : ApiController
    {
        private IAccountDomain accountDomain;

        public AccountController()
        {
            this.accountDomain = new AccountDomain();
        }

        public IEnumerable<AccountModel> Get()
        {
            var accounts = this.accountDomain.ListAccounts();

            List<AccountModel> accountsModel = new List<AccountModel>();

            foreach (var account in accounts)
            {
                AccountModel accountModel = new AccountModel();
                accountModel.Id = account.Id.Value;
                accountModel.Name = account.Name;
                accountModel.Balance = 0M;

                accountsModel.Add(accountModel);
            }

            return accountsModel;
        }

        public AccountModel Get(int id)
        {
            return new AccountModel() { Id = 1, Name = "Account1", Balance = 1900.99M };
        }

        public AcknowledgeModel Post([FromBody]AccountModel account)
        {
            var id = this.accountDomain.InsertAccount(new DTOAccount()
            {
                Name = account.Name
            });

            return new AcknowledgeModel() { ProcessedId = id, Message = "Account Inserted" };
        }

        public AcknowledgeModel Put(int id, [FromBody]AccountModel accounts)
        {
            return new AcknowledgeModel() { ProcessedId = id, Message = "Account Updated" };
        }

        public AcknowledgeModel Delete(int id)
        {
            this.accountDomain.DeleteAccount(id);

            return new AcknowledgeModel() { ProcessedId = id, Message = "Account deleted" };
        }
    }
}
