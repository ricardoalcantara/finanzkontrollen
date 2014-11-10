using FinanzKontrollen.Domain.DataTransferObject;
using FinanzKontrollen.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzKontrollen.Infrastructure.MapperExtension
{
    public static class Extension
    {
        public static DTOUser ToDtoUser(this User user)
        {
            return (user != null ? new DTOUser()
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                Password = user.Password,
                Token = user.Token
            } : null);
        }

        public static User ToUser(this DTOUser dtoUser)
        {
            return (dtoUser != null ? new User()
            {
                Id = dtoUser.Id,
                Email = dtoUser.Email,
                Name = dtoUser.Name,
                Password = dtoUser.Password,
                Token = dtoUser.Token
            } : null);
        }
    }
}
