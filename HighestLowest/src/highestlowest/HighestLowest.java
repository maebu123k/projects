/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package highestlowest;

import java.util.Scanner;

/**
 *
 * @author MADMan
 */
public class HighestLowest {

    /**
     * @param args the command line arguments
     */
	public static void main(String[] args) {
		//Declare variable to store the numbers
		Integer[] num = new Integer[5];
		
		//Prompt user to input
		System.out.print("Enter five integers: ");
		
		//Read input as string
		Scanner sc = new Scanner(System.in);
		String input = sc.nextLine();
		
		//Split the string input into array.
		String[] input_splitted = input.split(" ",5);
		
		//Convert input to integer and store in array
		for (int x = 0; x < 5; x++){
			num[x] = Integer.parseInt(input_splitted[x]);
		}
		
		
		//Declare variable to store the highest number, with initial value of the first array element
		int highest_num = num[0];		
		
		//For each element of the array, compare it with the value stored in the highest_num variable.
		//If the array element is higher, replace it in the highest_num variable
		for (int h = 1; h < 5; h++) {
			if (num[h] > highest_num)
				highest_num = num[h];
		}
		
		//Declare variable to store the lowest number, with initial value of the first array element
		int lowest_num = num[0];
		
		//For each element of the array, compare it with the value stored in the lowest_num variable.
		//If the array element is lower, replace it in the lowest_num variable
		for (int l = 1; l < 5; l++) {
			if (num[l] < lowest_num) {
				lowest_num = num[l];
			}
		}
		
		//Display the highest integer
		System.out.println("Highest integer is " + highest_num);
		
		//Display the lowest integer
		System.out.println("Lowest integer is " + lowest_num);
	}
    
}
