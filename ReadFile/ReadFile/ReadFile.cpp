#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main() {
    //2.1 In the program creat a string constant for the file name to store as "Week10a.dat".
    string filename = "Week10a.dat";

    //2.2 Create an ifstream object for file reading.
    ifstream MyReadFile(filename);

    //2.3 Using the file object from Step 2.2, Open the file referring to the constant in Step 2.1
    MyReadFile.open(filename);

    //2.4 Creat a double variable to store the data for a line read from the file.
    double numReadValue;

    //2.5 Creat a double variable to store the accumulated balance. Initialize this to zero.
    double numAccumValue = 0;

    //**These are the variables that directly stores the read values from the line in the file
    //The values are read and stored as string, then is converted to character first
    //Afterwards, it will be converted to double where it will be stored in the double variable declared before
    char* chRead;
    string strRead;

    //2.6 Creat a loop to process the file - reading the line and adding data to your variable in Step 2.5.x
    while (getline(MyReadFile, strRead)) {
        chRead = &strRead[0]; //Convert the read line of file to character
        numReadValue = atof(chRead); //Convert the character string to double
        numAccumValue = numAccumValue + numReadValue; //Accumulate the read values
    }

    //2.7 Once the contents are read, close the file.
    MyReadFile.close();

    //2.8 Display the results below as - where the number in red is calculated from the summation of reading the file contents.
    printf("\nThe current balance is %.2f\n", numAccumValue);
}
