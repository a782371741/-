using System;
using System.Collections;
using System.Collections.Generic;

public class Bank {

	List<Account> accounts = new List<Account>();
	
	public Account OpenAccount(string id, string pwd, double money)
	{
		Account account = new Account(id, pwd, money);
		accounts.Add( account );
		
		return account;
	}
	
	public bool CloseAccount( Account account) 
	{
		int idx = accounts.IndexOf(account);
		if( idx<0 )return false;
		accounts.Remove(account);
		return true;		
	}
	
	public Account FindAccount(string id, string pwd)
	{
		foreach(Account account in accounts)
		{
			if( account.IsMatch(id, pwd))
			{
				return account;
			}
		}
        //for (int i = 0; i < accounts.Count; i++)
        //{
        //    Account account = accounts[i];

        //    if( account.IsMatch(id, pwd))
        //    {
        //        return account;
        //    }
        //}

		return null;
	}
    List<CreditAccount> Creditaccounts = new List<CreditAccount>();

    public CreditAccount OpenCreditaccount(string id, string pwd, double money, double Creditline)
    {
        CreditAccount Creditaccount = new CreditAccount(id, pwd, money,Creditline);
        Creditaccounts.Add(Creditaccount);

        return Creditaccount;
    }

    public bool CloseCreditAccount(CreditAccount Creaditaccount)
    {
        int idx = accounts.IndexOf(Creaditaccount);
        if (idx < 0) return false;
        accounts.Remove(Creaditaccount);
        return true;
    }

    public CreditAccount FindCreditAccount(string id, string pwd)
    {
        foreach (CreditAccount Creditaccount in Creditaccounts)
        {
            if (Creditaccount.IsMatch(id, pwd))
            {
                return Creditaccount;
            }
        }
        //for (int i = 0; i < accounts.Count; i++)
        //{
        //    Account account = accounts[i];

        //    if( account.IsMatch(id, pwd))
        //    {
        //        return account;
        //    }
        //}

        return null;
    }
}
