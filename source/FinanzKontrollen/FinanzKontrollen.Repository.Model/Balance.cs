using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollen.Repository.Model
{
    public class Balance
    {
        public DateTime Date { get; set; }
        public int UpToDate { get; set; }
        public int Id { get; set; }
        public int AccountId { get; set; }
        public double Ammount { get; set; }
    }
}