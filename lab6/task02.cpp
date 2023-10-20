#include<iostream>
using namespace std;
bool result(int num);
main()
{
    int threeDigNum;
    cout<<"Enter a 3-digit number: ";
    cin>> threeDigNum;
    cout<<result(threeDigNum);
}

bool result(int num)
{
    int third_num = num % 10;
      int sec_num=  (num /10) %10;
      int first_num = num/100;
      int sum = third_num + sec_num + first_num;

      if(sum % 2==0  &&  num % 2==0)
      {
        return true;   
      }

      if(sum%2!=0 && num%2!=0)
      {
        return true;
      }

      if(sum % 2==0 &&   num%2!=0)
      {
        return false;
      }

      if(sum % 2!=0 && num%2==0)
      {
        return false;
      }
      return false;
}