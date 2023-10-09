#include<iostream>
using namespace std;
void PassOrfail (int age);
main()
{
  
 int score;
 cout<< "Enter your score: ";
 cin >> score;  
  
PassOrfail(score);
}

void PassOrfail(int result)
{
    
 if(result <= 50)
{
cout<<"Fail";
}

if(result > 50)
{
cout<<"Pass";
}
} 