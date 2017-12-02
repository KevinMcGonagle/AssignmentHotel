package ie.lyit.testers;
import ie.lyit.BookSerializer.*;

public class testers 
{
	public static void main(String[]args)
	{
		BookSerializer bookSerializer = new BookSerializer();
		
		bookSerializer.add();
		bookSerializer.add();
		
		bookSerializer.writeRecordsToFile();
	}
}
