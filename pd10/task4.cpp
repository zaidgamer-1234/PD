#include<iostream>
#include<vector>
using namespace std;
int Volume(vector<int>&Dimensions);


main()
{
  int numOfBoxes;
  cout<<"Enter the number of boxes: ";cin>>numOfBoxes;
  cout<<"Enter the dimensions of the boxes (length, width, height):"<<endl;
  int totalDim = 3 * numOfBoxes;
  vector<int> Dimensions(totalDim);

  for(int i=0 ; i<Dimensions.size() ; i++)
  {
   cin>>Dimensions[i];
  }
  int result = Volume(Dimensions);

  cout<<"Total volume of all boxes: "<<result;



}

int Volume(vector<int>&Dimensions)
{
  int TotalVol = 0;
  for(int i=0 ; i<Dimensions.size() ;  i+=3)
  {
    int length = Dimensions[i];
    int width  = Dimensions[i+1];
    int height = Dimensions[i+2];

    int volume = length * width * height;

     TotalVol += volume; 
  }
  return TotalVol;
}