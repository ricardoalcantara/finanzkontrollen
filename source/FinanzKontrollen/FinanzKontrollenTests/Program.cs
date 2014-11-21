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
            FinanzKontrollen.Presentation.RestClientApi.Account accountApi = new FinanzKontrollen.Presentation.RestClientApi.Account();

            var account = accountApi.Get();
        }
    }
}