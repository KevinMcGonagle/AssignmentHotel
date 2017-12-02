package ie.lyit.flight;

public class Name {
	
	private String title, firstName, surname;
	
	public Name()
	{
		title=firstName=surname=null;
	}
	
	public Name(String t, String fN, String sn)
	{
		title=t;
		firstName=fN;
		surname=sn;
	}
	
	public String toString()
	{
		return title + " " + firstName + " " + surname;
	}
	
	@Override 
	public boolean equals (Object obj)
	{
		Name nObject;
		if(obj instanceof Name)
			nObject = (Name)obj;
		else
			return false;
		return this.title.equals(nObject.title)
				&& this.firstName.equals(nObject.firstName)
				&& this.surname.equals(nObject.surname);
	}
	
	public String getTitle()
	{
		return title;
	}
	
	public void setTitle(String setTitleTo)
	{
		title=setTitleTo;
	}
	
	public String getFirstName()
	{
		return firstName;
	}
	
	public void setFirstName(String setFirstNameTo)
	{
		firstName=setFirstNameTo;
	} 

	
	public String getSurname()
	{
		return surname;
	}
	
	public void setSurname(String setSurnameTo)
	{
		surname=setSurnameTo;
	}
	
	public boolean isFemale()
	{
		if(title.equalsIgnoreCase("Miss") ||
				title.equalsIgnoreCase("Ms") ||
				title.equalsIgnoreCase("Mrs")) 
				return true;
		else 
			return false;
	}

}
