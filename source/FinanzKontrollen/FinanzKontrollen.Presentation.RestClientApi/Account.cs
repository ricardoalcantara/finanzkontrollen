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

        public IEnumerable<AccountModel> Get()
        {
            RestClient client = this.GetRestClient();
            RestRequest request = GetRequest(Account.GET, Method.GET);

            IRestResponse<List<AccountModel>> response = client.Execute<List<AccountModel>>(request);
            return response.Data;
        }        
    }
}
