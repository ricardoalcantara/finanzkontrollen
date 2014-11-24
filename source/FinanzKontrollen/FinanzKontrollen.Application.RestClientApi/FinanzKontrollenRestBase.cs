using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollen.Application.RestClientApi
{
    public abstract class FinanzKontrollenRestBase
    {
        private string _FinanzKontrollenUrlBase;

        public string FinanzKontrollenUrlBase
        {
            get
            {
                return _FinanzKontrollenUrlBase;
            }
            set
            {
                _FinanzKontrollenUrlBase = value;
            }
        }

        public FinanzKontrollenRestBase()
        {
            this.FinanzKontrollenUrlBase = System.Configuration.ConfigurationManager.AppSettings["finanzkontrollen"];

            if (!string.IsNullOrWhiteSpace(this.FinanzKontrollenUrlBase) &&
                !this.FinanzKontrollenUrlBase.EndsWith("api"))
            {
                if (!this.FinanzKontrollenUrlBase.EndsWith("/"))
                {
                    this.FinanzKontrollenUrlBase += "/";
                }

                this.FinanzKontrollenUrlBase += "api";
            }
        }

        protected RestClient GetRestClient()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(this.FinanzKontrollenUrlBase);
            
            return client;
        }

        protected RestRequest GetRequest(string url, Method method)
        {
            RestRequest request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Resource = url;
            request.Method = method;
            return request;
        }
    }
}
