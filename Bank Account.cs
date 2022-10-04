using System;

public class BankAccount
{
	public Class BankAccount
	{
	    public BankAccount ()
	    {
        }
	    
	    private double balance = 0;

	    public void deposit(double amount)
	    {
		    balance = amount;
	    }


	    public string GetBalance()
	    {
		   return $"{balance}";
	    }
}
