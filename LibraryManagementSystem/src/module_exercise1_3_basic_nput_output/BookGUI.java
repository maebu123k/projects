package module_exercise1_3_basic_nput_output;

import javax.swing.*;  

public class BookGUI {
	//class attributes
	static int bookId;
	static String title;
	static String ISBN;
	static String category;
	
	JFrame f;  //Declaring the frame
	
	//Constructor for the GUI
	BookGUI(){  
	    f = new JFrame();  
	    bookId = Integer.parseInt(JOptionPane.showInputDialog(f,"Enter the Book Id: "));  //Input dialog for the book ID
	    title = JOptionPane.showInputDialog(f,"Enter the Book Title: ");				  //Input dialog for the book Title
	    ISBN = JOptionPane.showInputDialog(f,"Enter the Book ISBN: ");					  //Input dialog for the book ISBN
	    category = JOptionPane.showInputDialog(f,"Enter the Book category: ");			  //Input dialog for the book Category
	    
	    //Message dialog showing the output
	    JOptionPane.showMessageDialog(f,"Here are the entered values:\n\tBook Id: " + bookId + "\n\tBook Title: " + title + "\n\tBook ISBN: " + ISBN + "\n\tBook category: " + category);  
	}  
	
	//Main method to call the constructor BookGUI
	public static void main(String[] args) {
		new BookGUI();
	}
	

}
