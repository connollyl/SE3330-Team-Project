#pragma once
#include <string>
#include <vector>
#include "MenuItem.h"

using namespace std;

class Option
{
private:
   int addedCalories;
   string name;
   string picture;
   float price;
public:
   Option(string optionName, float optionPrice, int cal)
   {
      name = optionName;
      price = optionPrice;
      addedCalories = cal;
   }
   string getName() 
   {
      return name;
   }
};