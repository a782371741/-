
public class Account {

    double money; 
	string id;
	string pwd;

	public Account( string id, string pwd, double money )
	{
	
		this.id = id;
		this.pwd = pwd;
		this.money = money;
	}
	
	public double GetMoney()
	{
		return money;
	}
	
	public void SetMoney(double val)
	{
		this.money = val;
	}
	
	public string GetId()
	{
		return id;
	}
		
	public void SetId(string id)
	{
		this.id = id;
	}
		
	public string Getpwd()
	{
		return pwd;
	}
		
	public void SetPwd(string pwd)
	{
		this.pwd = pwd;
	}
	
	public bool SaveMoney( double money)
	{
		if( money < 0 ) return false;  //ÎÀÓï¾ä
		
		this.money += money;
		return true;		
	}
	
	public bool WithdrawMoney( double money)
	{
		if( this.money >= money )
		{
			this.money -= money;
			return true;
		}

		return false;
            
	}
	
	public bool IsMatch( string id, string pwd )
	{
		return id==this.id && pwd==this.pwd;
	}
	
	
	
}



