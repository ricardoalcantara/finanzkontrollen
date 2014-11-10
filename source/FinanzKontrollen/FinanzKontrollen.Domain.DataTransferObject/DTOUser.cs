using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollen.Domain.DataTransferObject
{
    public class DTOUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public int Id { get; set; }
    }
}