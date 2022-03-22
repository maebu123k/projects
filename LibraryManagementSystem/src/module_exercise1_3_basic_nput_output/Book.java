//Lastname, Firstname
//Course and Section
//Date
//Week
//Topic

package module_exercise1_3_basic_nput_output;
import java.util.*;
import java.io.*;


public class Book {
	//class attributes
	static int bookId;
	static String title;
	static String ISBN;
	static String category;
	
	public static void main(String[] args) throws IOException {
		
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);			//Declare the Scanner object sc to be used for reading user input	
		System.out.print("Enter the Book Id: ");		//Prompts user to input Boook Id
		bookId = Integer.parseInt(sc.nextLine());		//Reads input using Scanner object
		
		System.out.print("Enter the Book Title: ");		//Prompts user to input Book Title
		title = sc.nextLine();							//Reads input using Scanner object
		
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));    //Declare the BufferedReader and InputStreamReader object br to be used for reading user input   	   	
		System.out.print("Enter the Book ISBN: ");				//Prompts user to input Book ISBN
		ISBN = br.readLine();									//Reads input using BufferedReader object
		
		System.out.print("Enter the Book category: ");			//Prompts user to input Book category
		category = br.readLine();								//Reads input using BufferedReader object
		
		//Prints out the user input
		System.out.println("\nHere are the entered values:");
		System.out.println("Book Id: " + bookId + "\n Book Title: " + title + "\nBook ISBN: " + ISBN + "\nBook category: " + category);

	}
	
}
