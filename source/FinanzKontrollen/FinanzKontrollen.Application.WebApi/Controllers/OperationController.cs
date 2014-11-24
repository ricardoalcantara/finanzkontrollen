using FinanzKontrollen.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinanzKontrollen.Application.WebApi.Controllers
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
        public AcknowledgeModel Post([FromBody]OperationModel accounts)
        {
            return new AcknowledgeModel() { ProcessedId = 0, Message = "Operation Inserted" };
        }

        // PUT api/values/5
        public AcknowledgeModel Put(int id, [FromBody]OperationModel accounts)
        {
            return new AcknowledgeModel() { ProcessedId = id, Message = "Operation Updated" };
        }

        // DELETE api/values/5
        public AcknowledgeModel Delete(int id)
        {
            return new AcknowledgeModel() { ProcessedId = id, Message = "Operation Inserted" };
        }
    }
}
