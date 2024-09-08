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
            new Account { id = 1, amount = 1000, date = DateTime.Now, remark = "Initial deposit" },
            new Account { id = 2, amount = 2000, date = DateTime.Now, remark = "Initial deposit" },
            new Account { id = 3, amount = 3000, date = DateTime.Now, remark = "Initial deposit" },
            new Account { id = 4, amount = 4000, date = DateTime.Now, remark = "Initial deposit" },
            new Account { id = 5, amount = 5000, date = DateTime.Now, remark = "Initial deposit" }
        };
        nextId = 6;
    }
    
}