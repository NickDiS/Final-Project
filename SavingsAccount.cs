using System;

class SavingsAccount : BankAccount
{
  public override double Balance { 
  get{ return balance; } 
  set{
  if (value >= 2500)
    balance = value;
  else
  Console.WriteLine ("The Balance cannot be less than $2500");
  }
  }

  //Constructor no parameters
  public SavingsAccount() : base()
  {
    
  }

  //Constructor with parameters
  public SavingsAccount(string accountnumber, string name, double balance) : base (accountnumber, name, balance)
  {
    
  }

  //Methods
  public override void CalculateInterest(){
    
    Balance = Balance + (Balance*.05) ; 
    Console.WriteLine ("Added interest and updated Balance");
    Console.WriteLine ("Current updated Balance is $"+Balance);
  }

  public override void Withdraw(double amount)
  {
  if (Balance < 2500)
    Console.WriteLine ("Insufficient balance.");
  else
    base.Withdraw(amount);
  }
}