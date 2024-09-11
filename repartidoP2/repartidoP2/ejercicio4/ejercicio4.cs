namespace repartidoP2.ejercicio4;

namespace repartidoP2;

public class Account
{
    public int Number { get; set; }
    public double Balance { get; set; }
    public string Titular { get; set; }

    public Account(int number, double balance, string titular)
    {
        this.Number = number;
        this.Balance = balance;
        this.Titular = titular;
    }

    public int AddToBalance(double amount)
    {
        
    }

    public int RemoveFromBalance(double amount)
    {
        
    }

    public int TransferTo(Account account, double amount)
    {
        
    }
}

public class Bank
{
    public int Number { get; set; }
    public double Balance { get; set; }
    public string Titular { get; set; }

    public Bank(int number, double balance, string titular)
    {
        this.Number = number;
        this.Balance = balance;
        this.Titular = titular;
    }
}