using Microsoft.EntityFrameworkCore;
namespace csharp_cpp_java_bank_account
{
    public class BankAccountContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=BankAccountDb;Trusted_Connection=True;");
        }
    }
}