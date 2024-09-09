using mvc_ska.Models;

namespace mvc_ska.services;

public class AccountService
{
    public List<Account> accounts;
    public int nextId;
    public AccountService()
    {
        accounts = new List<Account>
        {
            new Account { Id = 1, Amount = 1000, Date = DateTime.Now, Remark = "Initial deposit" },
            new Account { Id = 2, Amount = 2000, Date = DateTime.Now, Remark = "Initial deposit" },
            new Account { Id = 3, Amount = 3000, Date = DateTime.Now, Remark = "Initial deposit" },
            new Account { Id = 4, Amount = 4000, Date = DateTime.Now, Remark = "Initial deposit" },
            new Account { Id = 5, Amount = 5000, Date = DateTime.Now, Remark = "Initial deposit" }
        };
        nextId = 6;
    }
    
}