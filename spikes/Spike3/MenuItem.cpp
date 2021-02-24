/*#include "MenuItem.h"

void MenuItem::addOption(Option* newOption)
{
   options.push_back(newOption);
}

void MenuItem::removeOption(int index)
{
   options.erase(options.begin() + index);
}

void MenuItem::updateName(string newName)
{
   name = newName;
}

void MenuItem::updateDescription(string newDesc)
{
   description = newDesc;
}

void MenuItem::updateCalories(int newCal)
{
   calories = newCal;
}

void MenuItem::updatePrice(float newPrice)
{
   price = newPrice;
}

void MenuItem::updatetimeCost(float newTime)
{
   timeCost = newTime;
}

Option* MenuItem::getOption(string name)
{
   for (int i = 0; i < options.size(); i++)
      if (options[i]->getName() == name) return options[i];
   return NULL;
}

int MenuItem::getCalories()
{
   return calories;
}

string MenuItem::getName()
{
   return name;
}

float MenuItem::getPrice()
{
   return price;
}

float MenuItem::getTimeCost()
{
   return timeCost;
}

string MenuItem::getDescription()
{
   return description;
}

int MenuItem::getOptionsListSize()
{
   return options.size();
}

bool MenuItem::operator< (const MenuItem & compareFrom) const
{
   return name < compareFrom.name;
}*/

int main()
{
   return 0;
}