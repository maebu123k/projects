import java.io.*;
import java.util.*;

public class PigLatin {

	public static void main(String[] args) {
		//DECLARE NUMBER OF LINES COUNTER AND COUNTER VARIABLE
		int input_count = 0, counter = 0, first_vowel = 0;
		
		//READ INPUT FILE TO COUNT THE NUMBER OF WORDS 
	    try {
	        File fileincount = new File("in.txt");
	        Scanner myReader = new Scanner(fileincount);
	        while (myReader.hasNextLine()) {
		      //ADDS 1 TO COUNTER VARIABLE FOR EACH LINE READ
	          myReader.nextLine();
	          input_count++;
	        } 
	        //CLOSE THE READER
	        myReader.close();
	      //DISPLAYS AN ERROR MESSAGE IN CASE THERE IS AN 
	      //ERROR IN THE INPUT FILE   
	      } catch (FileNotFoundException e) {
	        System.out.println("An error occurred.");
	        e.printStackTrace();
	      }
	    
	    //DECLARE STRING ARRAY DEPENDING ON THE NUMBER OF READ LINES	    
	    String[] output = new String[input_count];
	    
		//READ INPUT FILE FOR THE SECOND TIME AND TRANSLATE EACH WORD TO PIG LATIN
	    try {
	        File filein = new File("in.txt");
	        Scanner myReader = new Scanner(filein);
	        while (myReader.hasNextLine()) {
	          String data = myReader.nextLine();
	          
	          //SEARCH FOR THE FIRST OCCURENCE OF THE VOWEL AND Y IN THE WORD
	          //IF FOUND, SAVE THE INDEX NUMBER AND TERMINATE THE LOOP
	          for (int y = 0; y <= data.length()-1; y++) {
	        	  if (data.charAt(y) == 'a' || data.charAt(y) == 'e' || data.charAt(y) == 'i' || data.charAt(y) == 'o' || data.charAt(y) == 'u' || data.charAt(y) == 'y') {
	        		  //IF THE FIRST CHARACTER IS Y AND THE FIRST IN THE WORD, IT IS TREATED AS CONSONANT
	        		  if (data.charAt(y) == 'y' && y == 0)
	        			  continue;
	        		  else {
	        			  first_vowel = y;
	        			  break;
	        			  }
	        	  }	        		  
	          }
	          
	          //IF FIRST VOWEL IS THE FIRST CHARACTER, SIMPLY ADD "ay" AT THE END OF THE WORD
	          if (first_vowel == 0)
	        	  output[counter] = data + "ay";
	          //OTHERWISE, GET THE CONSONANTS BEFORE THE FIRST OCCURENCE OF VOWEL, PUT IT
	          //AT THE END OF THE WORD FOLLOWED BY "ay"
	          else
	        	  output[counter] = data.substring(first_vowel) + data.substring(0,first_vowel) + "ay";    
	          
	          //ADD 1 TO COUNTER
	          counter++;
	        }
	        //CLOSE THE READER
	        myReader.close();
	      //DISPLAYS AN ERROR MESSAGE IN CASE THERE IS AN ERROR IN THE INPUT FILE
	      } catch (FileNotFoundException e) {
	        System.out.println("An error occurred.");
	        e.printStackTrace();
	      }
	    
		//WRITE OUTPUT FILE
	    try {
	        FileWriter myWriter = new FileWriter("out.txt");
	        //LOOPS THROUGH THE OUTPUT ARRAY AND WRITES ITS CONTENTS IN OUT.TXT
	        for (int x = 0; x < input_count; x++)
	        	myWriter.write(output[x] + "\n");
	        
	        System.out.println("Successfully wrote to the file.");
	        myWriter.close();
	    //DISPLAYS AN ERROR MESSAGE IN CASE THERE IS AN ERROR IN THE OUTPUT FILE
	      } catch (IOException e) {
	        System.out.println("An error occurred.");
	        e.printStackTrace();
	      }
	}
}

