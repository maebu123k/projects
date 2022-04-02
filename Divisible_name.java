import java.io.*;

/*This program reads a positive integer and then checks to see whether or not
the integer is divisible by 11.  For that divisibility test, use the following
algorithm, based on one given by the mathematician Lewis Carroll.*/
public class Divisible_name
{
   public static void main (String[] args)throws IOException
   {
      BufferedReader In = new BufferedReader(new InputStreamReader(System.in)); 
      
       //Declares variables
       int numberIn, numberB, numberC, numberD, numberDup;

       numberIn = 0;
       //While loop which works when user input is not 99999
       while (numberIn != 99999)
       {
	   //MODIFIED CODE STARTS HERE
	   //Declare a boolean flag that checks if the input is valid
	   boolean flValidInput = false; 
	   
	   //Continuously asks the user for input until a valid input is provided
	   while (flValidInput == false) {
		   System.out.println ("\nEnter a positive number or enter '99999' to end the program: ");
		 
		   //Try block
		   try {
			    //Read input as integer
			   numberIn = Integer.parseInt(In.readLine());
			   //If input is less than 0, throw a number format exception
			   if (numberIn < 0)
				throw new NumberFormatException();
			   
			   //Set validation flag to true if no error in parsing
			   flValidInput = true;
		   }
		   //Catch block which will be performed if the input is not numeric
		   catch(NumberFormatException e) {
			   //Print error message
			   System.out.println("Error! Invalid integer. Try again.");
			   
			   //Set validation flag to false
			   flValidInput = false;
		   }
	   }
	   //MODIFIED CODE ENDS HERE

	   //While loop which implements the formula, and determines the output
	   while (numberIn > 9 && numberIn != 0 && numberIn > 0 && numberIn != 99999)
	   {

	       numberB = numberIn / 10;
	       numberC = numberIn % 10;
	       numberIn = numberB - numberC;
	       System.out.println (numberIn);

	   }

	   //If input is 99999, program end message is printed
	   if (numberIn == 99999)
	       System.out.println ("The program has ended.");

 

	   //If input is 0 number is divisible by 11
	   if (numberIn == 0)
	   {
	       System.out.println ("The number is divisible by 11.");
	   }
	   //Outputs a space, so that the else does not include the sentinel
	   else if (numberIn == 99999)
	   {
	       System.out.println ("\r");
	   }

	   //If none of the other cases occur, the number is not divisible
	   else

	       {
		   System.out.println ("The number is NOT divisible by 11.");
	       }
       }
   }
}
