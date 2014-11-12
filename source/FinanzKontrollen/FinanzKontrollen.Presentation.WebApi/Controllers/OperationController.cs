using FinanzKontrollen.Presentation.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinanzKontrollen.Presentation.WebApi.Controllers
{
    public class OperationController : ApiController
    {
        // GET api/values
        public IEnumerable<OperationModel> Get()
        {
            return new OperationModel[] { new OperationModel() { } };
        }

        // GET api/values/5
        public OperationModel Get(int id)
        {
            return new OperationModel() { };
        }

        // POST api/values
        public void Post([FromBody]OperationModel accounts)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]OperationModel accounts)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
