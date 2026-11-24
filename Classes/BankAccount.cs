namespace Classes;

public class BankAccount
{
    private static int S_accountNumberSeed = 1234567890;
    public string Number { get;}
    public string Owner {get; set;}
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach(var item in _allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }
    }

    public virtual void PerformMonthEndTransactions() { }

    // contrutores

    private readonly decimal _minimumBalance;

    public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

    public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
    {
        Number = S_accountNumberSeed.ToString();
        S_accountNumberSeed++;

        Owner = name;
        _minimumBalance = minimumBalance;
        if (initialBalance > 0)
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
    } 
    
    
    
    
    //Transações
    private List<Transaction> _allTransactions = new List<Transaction>();

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "amount o deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
    }
    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {   
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);
        Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
        Transaction? withdrawal = new(-amount, date, note);
        _allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                _allTransactions.Add(overdraftTransaction);
    }

    protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
    {
        if (isOverdrawn)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        else
        {
            return default;
        }
    }
    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();

        decimal balance = 0;

        report.AppendLine("|Date\t        |Amount\t|Balance |Note");

        foreach (var transaction in _allTransactions)
        {
            balance += transaction.Amount;

            report.AppendLine(
                $"|{transaction.Date.ToShortDateString()}\t" +
                $"|{transaction.Amount}\t" +
                $"|{balance}\t" +
                $" |{transaction.Notes}"
            );
        }

        return report.ToString();
    }
}
