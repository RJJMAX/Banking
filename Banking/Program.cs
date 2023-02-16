
using Banking;


var s1 = new SavingsComp();

s1.AccountId = "Greg";
s1.Description = "My Savings Account";
s1.Balance = 1000;

//s1.Deposit(100);
//s1.Withdraw(50);
//s1.Deposit(50);
//var interest = s1.PayInterest(3);

//Console.WriteLine($"S1 paid interest of {interest:C}");

Console.WriteLine($"S1 Balance is {s1.Balance:C}");
