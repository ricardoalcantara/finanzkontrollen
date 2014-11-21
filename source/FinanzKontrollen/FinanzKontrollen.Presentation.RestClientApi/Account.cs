using FinanzKontrollen.Presentation.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollen.Presentation.RestClientApi
{
    public class Account: FinanzKontrollenRestBase
    {
        private const string GET = "/account";
        private const string DELETE = "/account/{0}";

        public IEnumerable<AccountModel> Get()
        {
            RestClient client = this.GetRestClient();
            RestRequest request = GetRequest(Account.GET, Method.GET);

            IRestResponse<List<AccountModel>> response = client.Execute<List<AccountModel>>(request);
            return response.Data;
        }

        public AcknowledgeModel Insert(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public AcknowledgeModel Update(int id, AccountModel accounts)
        {
            throw new NotImplementedException();
        }

        public AcknowledgeModel Delete(int id)
        {
            RestClient client = this.GetRestClient();
            RestRequest request = GetRequest(string.Format(Account.DELETE, id), Method.DELETE);

            IRestResponse<AcknowledgeModel> response = client.Execute<AcknowledgeModel>(request);
            return response.Data;
        }
    }
}
