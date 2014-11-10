using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollen.Repository.Model
{
    public class OperationTag
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int OperationId { get; set; }
    }
}