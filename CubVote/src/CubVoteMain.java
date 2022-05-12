import java.io.File;  // Import the File class
import java.io.FileNotFoundException;  // Import this class to handle errors
import java.util.*; 

public class CubVoteMain {
	public static void main(String[] args) {
		//DECLARE NEW HASHMAP TO HOLD THE NOMINATIONS
		HashMap<String, String> nominations = new HashMap<String, String>();
		
		
		//READ THE data.txt FILE		
		  try {
		      File myObj = new File("data.txt");
		      Scanner myReader = new Scanner(myObj);
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        //SEPARATES THE NAME AND THE TRIBE NAME AND PUTS IN THE HASHMAP
		        nominations.put(data.substring(0,data.indexOf(":")),data.substring(data.indexOf(":")+1));
		      }
		      myReader.close();
		  } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		  }
		  
		  //CREATE THE HASHSET OF OBJECT CLASS CUBNOMINATION CONTAINING NAMES AND TRIBES THAT ARE FOR PANDACLAN
		  HashSet<CubNomination> forPandaClan = new HashSet<CubNomination>();  
		  
		  //CREATE THE HASHSET OF OBJECT CLASS CUBNOMINATION CONTAINING NAMES AND TRIBES THAT ARE FOR BLACKBEARS
		  HashSet<CubNomination> forBlackBears = new HashSet<CubNomination>();
		  
		  //SORT ENTRIES PER TRIBE
		  for (String i: nominations.keySet()) {
			  //IF TRIBE IS BLACKBEARS, ADD TO HASHSET OF FORBLACKBEARS
			  if (nominations.get(i).contentEquals("BlackBears")) 
				  forBlackBears.add(new CubNomination(i,nominations.get(i)));
			  //ELSE, ADD TO HASHSET OF FORPANDACLAN
			  else
				  forPandaClan.add(new CubNomination(i,nominations.get(i)));
		  }
		  
		  //DISPLAY CONTENTS OF BLACKBEAR HASHSET
		  Iterator<CubNomination> iter = forBlackBears.iterator();
		  while(iter.hasNext()) {		  
		  		CubNomination cb = iter.next();
		  		System.out.println("Name: " + cb.getName() + "\nTribe: " + cb.getTribeName());
		  }  
		  
		  //DISPLAY CONTENTS OF PANDACLAN HASHSET
		  Iterator<CubNomination> itr = forPandaClan.iterator();
		  while(itr.hasNext()) {		  
			  	CubNomination cb = itr.next();
				System.out.println("Name: " + cb.getName() + "\nTribe: " + cb.getTribeName());
			  }  
	  }
}
