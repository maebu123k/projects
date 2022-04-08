#include<iostream>
#include<fstream>
#include<string>
#include<iomanip>
#include<stdlib.h>
using namespace std;

//CHANGED VALUE OF N TO 35 TO ADHERE TO THE REQUIREMENT 'ASSUME YOU COULD HAVE
//A MAXIMUM OF 35 STUDENTS
//int N = 8;
const int N = 35;
//DECLARE A PUBLIC INTEGER counter WITH INITIAL VALUE OF 0
int counter = 0;

void importData(string array1[], string array2[], float array3[], float array4[], float array5[])
{
    char filename[80];

    cout << "Enter input file name: ";
    cin.getline(filename, 80);

    ifstream in(filename);

    if (!in)
    {
        cout << "Error in input file opening or input file doesn't exist.";
        exit(0);
    }

    //REPLACE THE COMMENTED CODE TO READ LINES ONLY UNTIL END OF FILE
    //WHILE COUNTING THE NUMBER OF RECORDS BY INCREMENTING counter VARIABLE
    //FOR EACH READ
    //for (int i = 0; i < N; i++)
    //{
    //    in >> array1[i] >> array2[i] >> array3[i] >> array4[i] >> array5[i];
    //}
    while (!in.eof()) {
        in >> array1[counter] >> array2[counter] >> array3[counter] >> array4[counter] >> array5[counter];
        counter++;
    }

    in.close();

    cout << "Successful data import" << endl;

    //ADDED THIS DISPLAY CODE TO DISPLAY THE NUMBER OF RECORDS READ
    cout << "There are " << counter << " records imported." << endl;
}
int main()
{
    string array1[N], array2[N];
    float array3[N], array4[N], array5[N];

    importData(array1, array2, array3, array4, array5);

    cout << endl << "Data imported from file is:" << endl;
    cout.setf(ios::left, ios::adjustfield);
    cout.precision(1);

    //CHANGED THE LIMIT OF LOOP TO DISPLAY ONLY
    //THOSE INDEXES WITH VALUES ONLY
    //for (int i = 0; i < N; i++)
    for (int i = 0; i < counter; i++)
    {
        cout << setw(15) << array1[i] << setw(15) << array2[i] << setw(15) << fixed << array3[i] << setw(15) << fixed << array4[i] << setw(15) << fixed << array5[i] << endl;
    }
    return 0;
}