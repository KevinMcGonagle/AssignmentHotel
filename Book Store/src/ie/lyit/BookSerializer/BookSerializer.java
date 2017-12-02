package ie.lyit.BookSerializer;

import java.util.ArrayList;
import ie.lyit.book.Book;


import java.io.*;

public class BookSerializer 
{
	private ArrayList<Book> books;
	
	private final String FILENAME = "books.ser";
	
	public BookSerializer()
	{
		books = new ArrayList<Book>();
	}
	
	public void add()
	{
		Book book = new Book();
		book.read();
		books.add(book);
	}
	
	public void writeRecordsToFile()
	{
		try
		{
			FileOutputStream fileStream = new FileOutputStream(FILENAME);
			ObjectOutputStream os = new ObjectOutputStream(fileStream);
			os.writeObject(books);
			os.close();
		}
		catch(FileNotFoundException fNFE)
		{
			System.out.println("Cannot create file to store books.");
		}
		catch(IOException ioE)
		{
			System.out.println(ioE.getMessage());
		}
	}
}
