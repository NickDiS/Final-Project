using System;

class MainClass {
  public static void Main (string[] args)
  {
    Console.WriteLine("Test constructor with no parameters");
    BankAccount a1 = new BankAccount();
    a1.DisplayAccountInfo();
    Console.WriteLine("");

    Console.WriteLine("Test BankAccount validation and over-Withdraw");
    BankAccount a2 = new BankAccount("123","John Doe", -500);
    a2.DisplayAccountInfo();
    a2.Withdraw(200);
    Console.WriteLine("");

    Console.WriteLine("Test BankAccount with parameters");
    BankAccount a3 = new BankAccount("123556","Jae Doe", 500);
    a3.DisplayAccountInfo();
    Console.WriteLine("");
    
    Console.WriteLine("Test BankAccount Deposit $500 and Withdraw $200 and interest");
    BankAccount a4 = new BankAccount("132456","Timmy Turrner", 500);
    a4.DisplayAccountInfo();
    a4.Deposit(500);
    a4.Withdraw(200);
    a4.CalculateInterest();
    Console.WriteLine("");

    Console.WriteLine("Test SavingsAccount validation Balance>$2500 and over-Withdraw");
    SavingsAccount a5 = new SavingsAccount("654321","Johny test", 500);
    a5.DisplayAccountInfo();
    a5.Withdraw(200);
    Console.WriteLine("");

    Console.WriteLine("Test SavingsAccount Withdraw and Calculate Interest");
    SavingsAccount a6 = new SavingsAccount("987654","Jimmy Newtron", 3500);
    a6.DisplayAccountInfo();
    a6.Withdraw(200);
    a6.CalculateInterest();
    Console.WriteLine("");

    Console.WriteLine("Test CheckingAccount validation and over-Withdraw");
    CheckingAccount a7 = new CheckingAccount("987321","Danny Phantom", 400);
    a7.DisplayAccountInfo();
    a7.Withdraw(200);
    Console.WriteLine("");

    Console.WriteLine("Test CheckingAccount Withdraw and interest");
    CheckingAccount a8 = new CheckingAccount("654998","Kid Danger", 4000);
    a8.DisplayAccountInfo();
    a8.Withdraw(200);
    a8.CalculateInterest();
    Console.WriteLine("");


    
  }
}