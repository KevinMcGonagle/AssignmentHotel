package ie.lyit.flight;

public abstract class Person 
	{
		protected Name name;//COMPSITION HAS A NAME
		protected String address;
		protected String phoneNumber;
		
		
		public Person() 
		{
			//Default constructor
			//Called when object is created like this
			//NOTE this wont work because person is abstract
			name=new Name();
			address=null;
			phoneNumber=null;
		}
		
		//Initialization Constructor
		//Called when object would have been created like this (not possible)
		//Peron pObj = new Person("Mr", "Joe", "Doe", "087 1234567");
		public Person(String t, String fN, String sn, String address, String phoneNumber)
		{
			name = new Name(t, fN, sn);
			this.address=address;
			this.phoneNumber=phoneNumber;
		}
		
		//toString() method
		//Calls Name toString() to display name and
		//then displays address and phonenumber 
		public String toString ()
		{
			return name + "," + address+ "," +phoneNumber;
		}
		
		//equals ()method
		//called when comparing an object with another object
		//calls names equals() to compare name to personIn's name, and
		//compare phoneNumber to personIn's phoneNumber
		@Override
		public boolean equals(Object obj)
		{
			Person pObject;
			if(obj instanceof Person)
				pObject = (Person) obj;
			else
				return false;
			
			return (name.equals(pObject.name)&&
					address.equals(pObject.address)&&
					phoneNumber.equals(pObject.phoneNumber));
		}
		
		//set() and get() methods
		public void setName(Name nameIn)
		{
			name = nameIn;
		}
		
		public Name getName()
		{
			return name;
		}
		
		public void setAddress(String  addressIn)
		{
			address = addressIn;
		}
		
		public String getAddress()
		{
			return address;
		}
		
		public void setPhoneNumber(String phoneNumberIn)
		{
			phoneNumber = phoneNumberIn;
		}
		
		public String getPhoneNumber()
		{
			return phoneNumber;
		}
		
	}
