using System;

class BankAccount
{
    // Fields
    private string accountHolder;
    private double balance;

    // Constructor
    public BankAccount(string accountHolder, double initialBalance)
    {
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. Current Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: {amount:C}. Current Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    // Method to check the balance
    public void CheckBalance()
    {
        Console.WriteLine($"Account Holder: {accountHolder}\nBalance: {balance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a bank account
        BankAccount myAccount = new BankAccount("John Doe", 1000.00);

        // Displaying the initial balance
        myAccount.CheckBalance();

        // Depositing money
        myAccount.Deposit(500);

        // Withdrawing money
        myAccount.Withdraw(200);

        // Checking the final balance
        myAccount.CheckBalance();
    }
}
