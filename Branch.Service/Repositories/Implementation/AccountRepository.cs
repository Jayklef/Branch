using Branch.DataAccess;
using Branch.Service.Dtos;
using Branch.Service.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Branch.Service.Repositories.Implementation
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BranchContext _context;

        public AccountRepository(BranchContext context)
        {
            _context = context;
        }

        public List<AccountDto> GetAllAccounts()
        {
            var accounts = _context.Accounts.Select(c => new AccountDto
            {
                Id = c.Id,
                CompanyName = c.CompanyName,
                Website = c.Website
            }).ToList();

            return accounts;
        }

        public void CreateAccount(AccountDto accountDto)
        {
            var account = new AccountDto
            {
                CompanyName = accountDto.CompanyName,
                Website = accountDto.Website
            };

            _context.Add(account);
            _context.SaveChanges();
        }

        public AccountDto GetAllAccountById(int Id)
        {
            var account = _context.Accounts.Where(c => c.Id == Id).Select(c => new AccountDto
            {
                Id = c.Id,
                CompanyName = c.CompanyName,
                Website = c.Website,
                Users = c.Users
            }).FirstOrDefault();

            return account;
        }

        public void UpdateAccount(AccountDto accountDto)
        {
            var account = _context.Accounts.Where(c => c.Id == accountDto.Id).FirstOrDefault();

            account.CompanyName = accountDto.CompanyName;
            account.Website = accountDto.Website;

            _context.SaveChanges();
        }

        public void DeleteAccount(int Id)
        {
            var account = _context.Accounts.Where(c => c.Id == Id).FirstOrDefault();

            _context.Remove(account);
            _context.SaveChanges();
        }
    }
}
