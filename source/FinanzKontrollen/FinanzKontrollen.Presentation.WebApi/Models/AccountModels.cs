using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanzKontrollen.Presentation.WebApi.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}