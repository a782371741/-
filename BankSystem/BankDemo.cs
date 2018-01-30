public class BankDemo {
	public static void Main(string [] args)
	{
		Bank bank = new Bank();
		bank.OpenAccount("2222", "2222", 20);
		bank.OpenAccount("3333", "3333", 50);
        bank.OpenCreditaccount("4444", "1", 500, 200);
		ATM atm = new ATM(bank);
		
		for( int i=0; i<5; i++)
		{
			atm.Transaction();
		}
	}
	
}
