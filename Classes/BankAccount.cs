namespace Classes;

public class BankAccount
{
    public string Number { get;}
    public string Owner {get; set;}
    public decimal Balance {get;}

    // contrutor 
    public BankAccount(string name, decimal initialBalance)
    {
        //O qualificador this só é necessário quando uma variável ou parâmetro locais têm o mesmo nome desse campo ou propriedade. 
        this.Owner = name; 
        this.Balance = initialBalance;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        
    }
    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        
    }
}
