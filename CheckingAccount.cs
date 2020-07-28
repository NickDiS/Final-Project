using System;

class CheckingAccount : BankAccount
{
  public override double Balance
  { 
    get{ return balance; } 
    set{
    if (value >= 500.00)
      balance = value;
    else
    Console.WriteLine ("The Balance cannot be less than $500.");
    }
  }

  //Constructor no parameters
  public CheckingAccount() : base()
  {
    
  }

  //Constructor with parameters
  public CheckingAccount(string accountnumber, string name, double balance) : base (accountnumber, name, balance)
  {
    
  }

   //Methods
  public override void CalculateInterest(){
    Balance = Balance + (Balance * .0075); 
    Console.WriteLine ("Added interest and updated Balance.");
    Console.WriteLine ("Current updated Balance is $"+Balance);
  }

  public override void Withdraw(double amount)
  {
  if (Balance <500)
    Console.WriteLine ("Insufficient balance.");
  else
    base.Withdraw(amount);

}
}