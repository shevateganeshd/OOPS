//OOPS
//3. Encapsulation
namespace EncapsulationConApp
{
    public class BankAccount
    {
        private string name;
        private int accountno;
        private double balance;

        public BankAccount(string name, int accountno, double balance)
        {
            this.name = name;
            this.accountno = accountno;
            this.balance = balance;
        }

        public void GetBankAccountDetails()
        {
            Console.WriteLine("Name: " + this.name +
                              " Account No: " + this.accountno +
                              " Balance: " + this.balance);
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Ganesh Shevate",10001,10000);
            BankAccount account2 = new BankAccount("Mangesh Shevate", 10002, 100000);

            account1.GetBankAccountDetails();
            Console.WriteLine("Balance: " + account1.GetBalance());
            account1.Deposit(5000);
            Console.WriteLine("After Deposit 5000");
            account1.GetBankAccountDetails();
            account1.Withdraw(500);
            Console.WriteLine("After Withdrawal 500");
            account1.GetBankAccountDetails();

            Console.WriteLine();

            account2.GetBankAccountDetails();
            Console.WriteLine("Balance: " + account2.GetBalance());
            account2.Deposit(1000);
            Console.WriteLine("After Deposit 1000");
            account2.GetBankAccountDetails();
            account2.Withdraw(500);
            Console.WriteLine("After Withdrawal 500");
            account2.GetBankAccountDetails();
            
            Console.ReadKey();
        }
    }
}
