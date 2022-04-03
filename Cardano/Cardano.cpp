// CardanoTriplet.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <math.h>
using namespace std;

int main()
{
    //Variable declaration
    int a = 0, b = 0, c = 0;

    //Holds the number of cardano triplets found
    int cardanocount = 0;

    //Holds the computed cardano triplet test
    double answer = 0.00;

    //Test each number from 0 to 400 using brute force
    for (a = 0; a <= 400; a++) {
        for (b = 0; b <= 400; b++) {
            for (c = 0; c <= 400; c++) {
                //Compute cardano triplet 
                answer = cbrt(a + b * (sqrt(c))) + cbrt(a - b * (sqrt(c)));

                //Evaluates if the computed value satisfied the condition
                if (answer == 1.000000) {
                    //If true, print the triplet along with the answer
                    printf("\nCardano Triplet found! (%i,%i,%i). Answer: %.6f", a, b, c, answer);
                    //Add 1 to the cardano triplet count
                    cardanocount++;
                }

            }
        }
    }
    //Displays the number of cardano triplet found
    cout << "\n\nTotal Cardano Triplet count: " << cardanocount;
}
