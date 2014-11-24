using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanzKontrollen.Application.Model
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}