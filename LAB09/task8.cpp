// #include<iostream>
// using namespace std;
// main()
// {
//    int arr1[2];

//    for(int i=0; i<2; i++)
//     {
//         cin>>arr1[i];
//     }
//     cout<<endl<<"Enter size of 2nd Array";
//     int size2;
//     cin>>size2;
//     int arr2[size2];

//     for(int i=0; i<size2; i++)
//         {
//             cin>>arr2[i];
//         }

//  cout<<"Array 1 values are : ";
//    for(int i=0; i<2; i++)
    
//     {
       
//         cout<<arr1[i]<<" ";
//     }
// cout<<"Array 2 values are : ";
//     for(int i=0; i<size2; i++)
    
//     {   
//         cout<<arr2[i]<<" ";
//     }

//     int actual_Arr[2+size2];

//     actual_Arr[0] = arr1[0];

    
 
//             for(int j=1; j<2+size2-1; j++)
//             {
//                 actual_Arr[j] = arr2[j-1];
//             }



//             actual_Arr[2+size2-1] = arr1[1];
        
//   cout<<"Actual Array values are : ";
//     for(int i=0; i<2+size2;i++)
        
//         { 
          
//             cout<<actual_Arr[i]<<" ";
//         }    

// }

// // void insertArrayMiddle(int firstArray , int firstArraySize , int secondArray , int secondArraySize)
// // {
    
// // }

#include<iostream>
using namespace std;
void insertArrayInMiddle(int firstArray[], int firstArraySize, int secondArray[], int secondArraySize); 

main()
{
    int firstArraySize , secondArraySize;
    cout<<"Enter the number of elements for the first array (must be 2): ";cin>>firstArraySize;
    cout<<"Enter "<<firstArraySize<<" elements for the first array, one per line:"<<endl;

    int firstArray[firstArraySize];

    for(int i=0 ; i<firstArraySize ; i++)
    {
        cin>>firstArray[i];
    }

    cout<<"Enter the number of elements for the second array: ";cin>>secondArraySize;
    cout<<"Enter "<<secondArraySize<<" elements for the second array, one per line:"<<endl;

    int secondArray[secondArraySize];

    for(int i=0 ; i<secondArraySize ; i++)
    {
        cin>>secondArray[i];
    }
    insertArrayInMiddle(firstArray, firstArraySize, secondArray, secondArraySize);


}
void insertArrayInMiddle(int firstArray[], int firstArraySize, int secondArray[], int secondArraySize) {
    int actual_Arr[firstArraySize + secondArraySize];

      actual_Arr[0]=firstArray[0];

    for (int i = 1; i < secondArraySize + firstArraySize-1; i++) {
        actual_Arr[i] = secondArray[i-1];
    }

    actual_Arr[firstArraySize + secondArraySize -1] = firstArray[1];

    cout << "Resulting array: [";
    for (int i = 0; i < firstArraySize + secondArraySize; i++) {
        if(i == firstArraySize + secondArraySize - 1 )  {
        cout << actual_Arr[i]; 
        break;   
        }
        cout << actual_Arr[i]<<","<< " ";
    }
    cout<<"]";     
    cout << endl;
}






