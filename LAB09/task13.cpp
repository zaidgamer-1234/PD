#include<iostream>
using namespace std;
void jazzifyChords(string chords[], int numChords);
int numChords;
main()
{
   cout<<"Enter the number of chords: ";cin>>numChords;
   cout<<"Enter "<<numChords<<" chords, one per line:"<<endl;

   string chords[numChords];
   for(int i=0 ; i<numChords ; i++)
   {
    cin>>chords[i];
   }
   jazzifyChords(chords, numChords);
   
}

void jazzifyChords(string chords[], int numChords)
{ 
   
   for(int i=0 ; i<numChords ; i++)
   {
     if(chords[i].back()!='7')
     {
        chords[i] = chords[i] + "7";
     }
   }
    cout<<"Jazzified chords: [";
   for(int i=0 ; i<numChords ; i++)
   {
      if(i == numChords-1)
      {
         cout<<chords[i];
         break;
      }
     cout<<chords[i]<<","<<" ";
   }
   cout<<"]";
   cout<<endl;
  
}