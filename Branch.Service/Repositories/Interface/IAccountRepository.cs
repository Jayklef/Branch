using Branch.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Branch.Service.Repositories.Interface
{
    public interface IAccountRepository
    {
        List<AccountDto> GetAllAccounts();
        AccountDto GetAllAccountById(int Id);

        void CreateAccount(AccountDto accountDto);

        void UpdateAccount(AccountDto accountDto);

        void DeleteAccount(int Id);
    }
}
