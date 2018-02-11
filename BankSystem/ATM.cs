using System;
using System.Collections;

public class ATM {
	
	Bank bank;
	public ATM( Bank bank)
	{
		this.bank = bank;
	}
	
	public void Transaction()
	{
		Show("please insert your card");
		string id = GetInput();

		Show("please enter your password");
		string pwd = GetInput();
		
		Account account = bank.FindAccount(id, pwd);
        CreditAccount Creditaccount = bank.FindCreditAccount(id, pwd);

        
        if ( account == null && Creditaccount == null)
		{
			Show("card invalid or password not corrent");
			return;
		}
        if (account != null)
        {
            Show("1: display; 2: save; 3: withdraw");
            string op = GetInput();
            if (op == "1")
            {
                Show("balance: " + account.GetMoney());
            }
            else if (op == "2")
            {
                Show("save money");
                string smoney = GetInput();
                double money = double.Parse(smoney);

                bool ok = account.SaveMoney(money);
                if (ok) Show("ok");
                else Show("eeer");

                Show("balance: " + account.GetMoney());
            }
            else if (op == "3")
            {
                Show("withdraw money");
                string smoney = GetInput();
                double money = double.Parse(smoney);

                bool ok = account.WithdrawMoney(money);
                if (ok) Show("ok");
                else Show("eeer");

                Show("balance: " + account.GetMoney());

            }
        }
            

        if (Creditaccount != null)
        {
                   Show("1: displaymoney; 2: save; 3: withdraw 4:displaycreditline;5:addCreditline");
        string op1 = GetInput();
        if (op1 == "1")
        {
            Show("balance: " + Creditaccount.GetMoney());
               
        }
        else if (op1 == "2")
        {
            Show("save money");
            string smoney = GetInput();
            double money = double.Parse(smoney);

            bool ok = Creditaccount.SaveMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + Creditaccount.GetMoney());
        }
        else if (op1 == "3")
        {
            Show("withdraw money");
            string smoney = GetInput();
            double money = double.Parse(smoney);

            bool ok = Creditaccount.WithdrawMoney(money);
            if (ok) Show("ok");
            else Show("eeer");

            Show("balance: " + Creditaccount.GetMoney());

        }
            else if (op1 == "4")
            {
                Show("Creditline");
                Show("Creditline:" + Creditaccount.GetCreditLine());
            }
            else if (op1 == "5")
            {
                Show("addCreditline");
                string screditline = GetInput();
                double creditline = double.Parse(screditline);

                bool ok = Creditaccount.AddCreditLine(creditline);
                if (ok) Show("ok");
                else Show("eeer");

                Show("balance: " + Creditaccount.GetCreditLine());
            }
        }


    }
	
	
	public void Show(string msg)
	{
		Console.WriteLine(msg);
	}
	public string GetInput()
	{
		return Console.ReadLine();// ÊäÈë×Ö·û
	}
}
