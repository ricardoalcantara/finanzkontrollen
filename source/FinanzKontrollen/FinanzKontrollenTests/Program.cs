using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollenTests
{
    class Program
    {
        static void Main(string[] args)
        {
            FinanzKontrollen.Application.RestClientApi.Account accountApi = new FinanzKontrollen.Application.RestClientApi.Account();

            var accounts = accountApi.Get();

            foreach (var account in accounts)
            {
                if (string.Compare(account.Name, "Itau", true) != 0)
                {
                    accountApi.Delete(account.Id);
                }
            }
        }
    }
}