package ie.lyit.flight;

public class Customer extends Person //INHERITANCE Customer is a person
//customer has name address and phonenumber from person
{
	private String emailAddress;//and email
	private int number;//AND number
	
	private static int nextNumber=1;//static
	
	public Customer()
	{
		super();
		emailAddress=null;
		number=nextNumber++;
	}
	
	public Customer(String t, String fN, String sn, String address, String pNo, String email)
	{ 
		super(t, fN, sn,address, pNo);
		emailAddress=email;
		number=nextNumber++;
	}
	
	@Override
	public String toString() 
	{
		return super.toString() + ","+ emailAddress;
	}
	
	@Override
	public boolean equals(Object obj)
	{
		Customer cObject;
		if(obj instanceof Customer)
			cObject = (Customer) obj;
		else
			return false;
		
		return (number == cObject.number);
				
	}
	
	public void setEmailAddress(String emailAddress)
	{
		this.emailAddress = emailAddress;
	}
	
	
}
