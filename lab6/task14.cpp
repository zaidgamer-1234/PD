#include <iostream>
using namespace std;
string calculateCost(float budget, string category, int numPeople)
{
    float ticketCost = 0;
    if (category == "VIP")
    {
        ticketCost = 499.99;
    }
    else if (category == "Normal")
    {
        ticketCost = 249.99;
    }
    float transportCost = 0;
    if (numPeople >= 1 && numPeople <= 4)
    {
        transportCost = budget * 0.75;
    }
    else if (numPeople >= 5 && numPeople <= 9)
    {
        transportCost = budget * 0.60;
    }
    else if (numPeople >= 10 && numPeople <= 24)
    {
        transportCost = budget * 0.50;
    }
    else if (numPeople >= 25 && numPeople <= 49)
    {
        transportCost = budget * 0.40;
    }
    else if (numPeople >= 50)
    {
        transportCost = budget * 0.25;
    }
    float totalCost = ticketCost * numPeople + transportCost;
    if (totalCost <= budget)
    {
        return "Yes! You have " + to_string(budget - totalCost) + " leva left.";
    }
    else
    {
        return "Not enough money! You need " + to_string(totalCost - budget) + " leva.";
    }
}

main()
{
    float budget;
    string category;
    int numPeople;
    cout << "Enter the budget: ";
    cin >> budget;
    cout << "Enter the category (VIP/Normal): ";
    cin >> category;
    cout << "Enter the number of people in the group: ";
    cin >> numPeople;
    cout << calculateCost(budget, category, numPeople);
}