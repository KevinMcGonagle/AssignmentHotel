package ie.lyit.testers;
import java.util.ArrayList;
import java.util.*;

import ie.lyit.flight.*;

public class NameTester {
	
	public static void main(String[] args) {
		Name personA = new Name();
				System.out.println(personA);
				
				personA.setTitle("Mr");
				personA.setFirstName("Homer");
				personA.setSurname("Simpson");
				
				System.out.println(personA);
				
				Name personB = new Name("Mrs", "Marge", "Simpson");
				System.out.println(personB);
				
				if(personA.equals(personB))
					System.out.println(personA+ " is the same as " + personB);
				
				else
					System.out.println(personA+ " is not the same as " + personB);
				
				if(personA.isFemale())
					System.out.println(personA+ " is female");
				
				else
					System.out.println(personA+ " is not female");
				
				ArrayList<Name> names = new ArrayList <Name>();
				names.add(new Name("Mr", "Bart", "Simpson" ));
				names.add(personA);
				names.add(personB);
				names.trimToSize();
				
				for(Name tempName:names)
					System.out.println(tempName);
				
				if(nameSearch(personA,names))
					System.out.println("FOUND");
				else 
					System.out.println("NOT FOUND");
	}
	
	public static boolean nameSearch(Name nameSearch, ArrayList<Name> listOfNames)
	{
		for(Name currentName:listOfNames)
		{
			if(currentName.equals(nameSearch))
				return true;
		}

		return false;
				
				
	}
}


