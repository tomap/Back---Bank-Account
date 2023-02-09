using Microsoft.AspNetCore.Mvc;
using csharp_cpp_java_bank_account;
using System.Collections.Generic;

namespace csharp_cpp_java_bank_account.Controllers
{
    [Route("api/[controller]")]
public class AccountController : Controller
{
    private BankAccountRepository repository;

    public AccountController(BankAccountRepository repository)
    {
        this.repository = repository;
    }

    [HttpPost("create")]
    public IActionResult CreateAccount([FromBody] int id)
    {
        BankAccount account = new BankAccount();
        account.Id = id;
        repository.AddAccount(account);
        repository.SaveChanges();
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetAccount(int id)
    {
        BankAccount account = repository.GetAccount(id);
        if (account == null)
        {
            return NotFound();
        }
        return Ok(account);
    }

    [HttpGet("all")]
    public IActionResult GetAllAccounts()
    {
        List<BankAccount> accounts = repository.GetAllAccounts();
        return Ok(accounts);
    }

    [HttpPost("{id}/deposit")]
    public IActionResult Deposit(int id, [FromBody] decimal amount)
    {
        BankAccount account = repository.GetAccount(id);
        if (account == null)
        {
            return NotFound();
        }
        account.Deposit(amount);
        repository.SaveChanges();
        return Ok();
    }

    [HttpPost("{id}/withdraw")]
    public IActionResult Withdraw(int id, [FromBody] decimal amount)
    {
        BankAccount account = repository.GetAccount(id);
        if (account == null)
        {
            return NotFound();
        }
        account.Withdraw(amount);
        repository.SaveChanges();
        return Ok();
    }

    [HttpGet("{id}/balance")]
    public IActionResult GetBalance(int id)
    {
        BankAccount account = repository.GetAccount(id);
        if (account == null)
        {
            return NotFound();
        }
        return Ok(account.GetBalance());
    }

    [HttpGet("{id}/transactions")]
    public IActionResult GetTransactionHistory(int id)
    {
        BankAccount account = repository.GetAccount(id);
        if (account == null)
        {
            return NotFound();
        }
        return Ok(account.GetTransactionHistory());
    }
}

    
}

