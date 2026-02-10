namespace AccountClass;

class Account
{
    public string AccountName { get; }
    private double balance;
    public double Balance
    {
        get => balance;
        set
        {
            if (value >= 0) balance = value;
        }
    }

    public Account(string AccountName, float balance)
    {
        this.AccountName = AccountName;
        this.balance = balance;
    }

    public void Show()
    {
        Console.WriteLine($"Owner: {AccountName} Banlance: ${balance}\nYou rock!!");
        Console.WriteLine("Hello World!!");
    }

    public void Deposit(float Money)
    {
        balance += Money;
    }

    public double GetBalance()
    {
        return balance;
    }

    public string GetAccountName()
    {
        return AccountName;
    }

    public bool withdraw(float Money)
    {
        if (balance < Money)
        {
            return false;
        }
        else
        {
            balance -= Money;
            return true;
        }
    }

    public bool transfer(Account accountTo, float Money)
    {
        if (balance < Money)
        {
            return false;
        }
        else
        {
            balance -= Money;
            accountTo.Deposit(Money);
            return true;
        }
    }
}
