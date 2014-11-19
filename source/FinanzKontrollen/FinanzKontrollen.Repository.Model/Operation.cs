using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollen.Repository.Model
{
    public class Operation
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PayDate { get; set; }
        public int TypeId { get; set; }
        public double Ammount { get; set; }
        public int? AccountId { get; set; }
    }
}