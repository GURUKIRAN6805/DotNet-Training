using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_for_transaction_for_a_banking_system
{
    public class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
            else
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
                Console.ReadLine();
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance to withdraw specified amount.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
                Console.ReadLine();
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Current balance: {balance:C}");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);
            account.Deposit(500);
            account.Withdraw(200);
            account.Withdraw(1500);
            account.CheckBalance();
            Console.ReadLine();
        }
    }
}
