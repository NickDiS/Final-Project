using System;

class BankAccount
{
  private string accountnumber;
  public double balance;
  private DateTime datecreated;
  public string AccountNumber
  {
    get{ return accountnumber;}
    set{
      if (value.Length==6)
        accountnumber = value;
      else
        Console.WriteLine("Account Number must be 6 characters.");
    }
  }
  public string Name {get; set;}
  public virtual double Balance
  {
    get{ return balance; } 
    set{
      if (value >= 0)
        balance = value;
      else
      Console.WriteLine ("The Balance cannot be negative.");
    }  
  }
  public DateTime DateCreated
  {
    get { return datecreated; } 
    set {
      if (value <= DateTime.Now)
        datecreated = value;
      else
        Console.WriteLine ("Date Created cannot be in the future.");
    }  
  }
  
  //Constructor no parameters
  public BankAccount() 
  {
    Name = "";
    AccountNumber = "      ";
    Balance = 0.00;
    DateCreated = DateTime.Now;
  }

  //Constructor with parameters
  public BankAccount(string accountnumber, string name, double balance) 
  {
    AccountNumber = accountnumber;
    Name = name;
    Balance = balance;
    DateCreated = DateTime.Now;
  }


  //Methods
  public void DisplayAccountInfo ()
  {
    Console.WriteLine("Account Number: "+AccountNumber);
    Console.WriteLine("Account Holder Name: "+ Name);
    Console.WriteLine("Current Balance: $" + Balance);
  }
 
 public void Deposit(double amount)
 {
    Console.WriteLine("Depositing $" + amount);
    Balance = Balance + amount;
    Console.WriteLine("The Updated Balance is $" + Balance);
  }

  public virtual void Withdraw(double amount)
  {
    if (Balance > amount){
      Console.WriteLine("Withdrawing $" + amount);
      Balance = Balance - amount;
    }
    else
    {
      Console.WriteLine ("Error Insufficent Funds available");
    }   
    Console.WriteLine("The Balance is: $" + Balance);
  }

  public virtual void CalculateInterest()
  {
    Console.WriteLine("This method will calculate Interest");
  }
}