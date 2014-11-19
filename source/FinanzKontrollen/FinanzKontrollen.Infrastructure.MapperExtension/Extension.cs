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

        public static DTOAccount ToDtoAccount(this Account account)
        {
            return (account != null ? new DTOAccount()
            {
                Id = account.Id,
                Name = account.Name,
            } : null);
        }

        public static Account ToAccount(this DTOAccount dtoAccount)
        {
            return (dtoAccount != null ? new Account()
            {
                Id = dtoAccount.Id,
                Name = dtoAccount.Name,
            } : null);
        }

        public static IEnumerable<DTOAccount> ToListDtoAccount(this IEnumerable<Account> accounts)
        {
            foreach (Account account in accounts)
            {
                yield return account.ToDtoAccount();
            }
        }

        public static DTOOperation ToDtoOperation(this Operation operation)
        {
            return (operation != null ? new DTOOperation()
            {
                Id = operation.Id,
                Name = operation.Name,
                Description = operation.Description,
                PayDate = operation.PayDate,
                TypeId = operation.TypeId,
                Ammount = operation.Ammount,
                AccountId = operation.AccountId
            } : null);
        }

        public static Operation ToOperation(this DTOOperation dtoOperation)
        {
            return (dtoOperation != null ? new Operation()
            {
                Id = dtoOperation.Id,
                Name = dtoOperation.Name,
                Description = dtoOperation.Description,
                PayDate = dtoOperation.PayDate,
                TypeId = dtoOperation.TypeId,
                Ammount = dtoOperation.Ammount,
                AccountId = dtoOperation.AccountId
            } : null);
        }

        public static IEnumerable<DTOOperation> ToListDtoOperation(this IEnumerable<Operation> operations)
        {
            foreach (Operation Operation in operations)
            {
                yield return Operation.ToDtoOperation();
            }
        }
    }
}
