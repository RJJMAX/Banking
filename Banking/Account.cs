using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking; 
internal class Account {
    public string AccountID { get; set; } = string.Empty; //unique id 
    public decimal Balance { get; set; } = 0; //account balance
    public string Description { get; set; } = String.Empty;

    public bool Deposit(decimal Amount) {
        if(Amount <= 0) {
            Console.WriteLine("Invalid Transaction. Amount cannot be zero or negative!");
            return false;
        }
        Balance += Amount; //Balance = Balance + Amount
        return true;
    }
    public bool Withdraw(decimal Amount) {
        
        if(Amount <= 0) {
            Console.WriteLine($"Invalid Transaction. Amount cannot be zero or negative!");
            return false;
        }
        if (Amount > Balance) {
            Console.WriteLine($"Insufficient Funds!");
            return false;
        }
        Balance -= Amount;
        return true;
    }
    public bool Transfer(decimal Amount, Account ToAccount) {
        if (Amount <= 0) {
            Console.WriteLine($"Invalid Transaction. Amount cannot be zero or negative!");
            return false;
        }
        /*
        var success = Withdraw(Amount);
        if (!success) {
            return false;
        }
            ToAccount.Deposit(Amount);
             return true;
        */
        if (Withdraw(Amount)) {                             //same as commented out section above
            ToAccount.Deposit(Amount);
            return true;
        }
            return false;
    }
}

