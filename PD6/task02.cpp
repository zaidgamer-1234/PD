#include <iostream>
#include <string>
using namespace std;
float calculation(float marksEnglish, float  marksMaths, float marksChemistry, float marksSocialScience, float marksBiology);
string calculateGrade(float average);


 main() {
    string studentName;
    float marksEnglish, marksMaths, marksChemistry, marksSocialScience, marksBiology;

    cout << "Enter student's name: ";
    cin>>studentName;

    cout << "Enter marks for English: ";
    cin >> marksEnglish;

    cout << "Enter marks for Maths: ";
    cin >> marksMaths;

    cout << "Enter marks for Chemistry: ";
    cin >> marksChemistry;

    cout << "Enter marks for Social Science: ";
    cin >> marksSocialScience;

    cout << "Enter marks for Biology: ";
    cin >> marksBiology;

    cout << "Student Name: " << studentName << endl;
    cout << "Percentage: " << calculation( marksEnglish,   marksMaths,  marksChemistry,  marksSocialScience,  marksBiology) << "%" << endl;
    float average =calculation( marksEnglish,   marksMaths,  marksChemistry,  marksSocialScience,  marksBiology);
    cout << "Grade: " << calculateGrade( average) << endl;

    
}


float calculation(float marksEnglish, float  marksMaths, float marksChemistry, float marksSocialScience, float marksBiology)
{
    float totalMarks = marksEnglish + marksMaths + marksChemistry + marksSocialScience + marksBiology;
    float percentage = (totalMarks / 500) * 100;
    return percentage;
}


string calculateGrade(float average) {
    if (average >= 90.0) {
        return "A+";
    } else if (average >= 80.0) {
        return "A";
    } else if (average >= 70.0) {
        return "B+";
    } else if (average >= 60.0) {
        return "B";
    } else if (average >= 50.0) {
        return "C";
    } else if (average >= 40.0) {
        return "D";
    } else {
        return "F";
    }
}


    
   






