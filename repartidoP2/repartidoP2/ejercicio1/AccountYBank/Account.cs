namespace repartidoP2.ejercicio1;

public class Account
{
    private int number;
    private double balance;
    private Person titular;
    
    public Account(int number, double balance, Person titular)
    {
        this.number = number;
        if (balance < 0)
        {
            throw new ArgumentException("El balance no puede ser negativo.");
        }
        this.balance = balance;
        this.titular = titular;
    }

    public double GetBalance()
    {
        return this.balance;
    }

    public string AddToBalance(double amount)
    {
        balance += amount;
        return ("Balance agregado con exito");
    }
    public string  RemoveFromBalance(double amount)
    {
        if (balance < amount)
        {
            return ($"No se puede debitar ${amount} porque no tiene fondos suficientes");
        }
        else
        {
            balance -= amount;   
            return ("Balance debitado con exito");
        }
    }

    public string TransferTo(Account account, double amount)
    {
        if (balance < amount)
        {
            return ($"No se puede transferir ${amount} porque no tiene fondos suficientes.");
        }
        else
        {
            this.RemoveFromBalance(amount); 
            account.AddToBalance(amount);   
            return ($"Transferencia de ${amount} a la cuenta {account.number} realizada con éxito.");
        }
    }

}