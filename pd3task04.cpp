#include<iostream>
using namespace std;

main(){

cout<<"Enter Imposter Count: ";

float Imposter_count;

cin>>Imposter_count;

cout<<"Enter Player Count: ";

float playerCount;

cin>>playerCount;


float chance_of_being_imposter= 100 * (Imposter_count/playerCount);

cout<<"Chance of being an imposter: " <<chance_of_being_imposter <<"%";
}
