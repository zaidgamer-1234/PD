#include<iostream>
using namespace std;
main()
{
    int mbs;
 cout<<"Enter the size in megabytes (MB): ";
 cin>>mbs; 

 float bits;
 bits=mbs*1024*1024*8;
 cout<<mbs<<" MB is equivalent to "<<bits<<" bits.";
}	