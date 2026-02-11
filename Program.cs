using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using AccountClass;
// simulated change from teammate on github
// second test
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing Account1");
        Account Account1 = new Account("Bob", 100);

        Console.WriteLine("About to withdraw 150 from Account1");
        if (Account1.withdraw(150))
        {
            Console.WriteLine("Success, new status: ");
            Account1.Show();
        }
        else
        {
            Console.WriteLine("Insufficient funds, current account info: ");
            Account1.Show();
        }

        Console.WriteLine("Depositing 200 into Account1, new status: ");
        Account1.Deposit(200);
        Account1.Show();

        Console.WriteLine($"About to withdraw 150 from {Account1.AccountName}");
        if (Account1.withdraw(150))
        {
            Console.WriteLine("Success, new status: ");
            Account1.Show();
        }
        else
        {
            Console.WriteLine("Insufficient funds, current account info: ");
            Account1.Show();
        }

        Console.WriteLine("Creating Account2 ");
        Account Account2 = new Account("Mary", 100);
        Account2.Show();

        Console.WriteLine("Transferring 50 from Bob to Mary ");
        if (Account1.transfer(Account2, 50))
        {
            Console.WriteLine("Success, new status: ");
            Account1.Show();
            Account2.Show();
        }
        else
        {
            Console.WriteLine("Insufficient funds, current account info: ");
            Account1.Show();
            Account2.Show();
        }

        Account1.Balance = 10000;
        Account1.Show();

        int? x1 = 20;
        int? x2 = null;

        nullable(x1);
        nullable(x2);

        string? s = null;
        Account? a = null;
        Console.WriteLine("Test1");
        Console.WriteLine("Test2");
    }

    public static void nullable(int? i)
    {
        if (i != null)
        {
            Console.WriteLine("The value is: " + i);
        }
        else
            Console.WriteLine("The value is null");
    }

}
