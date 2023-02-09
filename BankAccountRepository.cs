using System.Linq;
using System.Collections.Generic;

namespace csharp_cpp_java_bank_account
{
    public class BankAccountRepository
    {
        private readonly BankAccountContext context;
        private List<BankAccount> accounts;

        public BankAccountRepository(BankAccountContext context)
        {
            this.context = context;
            accounts = new List<BankAccount>();
        }

    public void AddAccount(BankAccount account)
    {
        accounts.Add(account);
    }

   public BankAccount GetAccount(int accountId)
    {
        return accounts.FirstOrDefault(a => a.Id == accountId);
    }
    public List<BankAccount> GetAllAccounts()
    {
        return accounts;
    }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}