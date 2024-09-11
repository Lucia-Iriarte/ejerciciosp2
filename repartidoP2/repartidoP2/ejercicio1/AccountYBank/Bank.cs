using System.Collections;

namespace repartidoP2.ejercicio1;

public class Bank
{
    private int numeroDeCuenta;
    public ArrayList accounts = new ArrayList();
    
    public Bank(int numeroDeCuenta)
    {
        this.numeroDeCuenta = numeroDeCuenta;
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public bool AccountIsValid(Account account)
    {
        if (accounts.Contains(account))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}