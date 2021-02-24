#pragma once
#include <iostream>
#include <string>
#include <vector>
#include "Options.h"

using namespace std;

class MenuItem
{
protected:
   bool availible;
   int calories;
   string description;
   string name;
   vector<Option*> options;
   float price;
   float timeCost;

public:
   MenuItem()
   {
      availible = false;
      calories = 0;
      description = "";
      name = "";
      price = 0.0f;
      timeCost = 0.0f;
   }
   MenuItem(int cal, string desc, string itemName, float itemPrice, float itemTimeCost)
   {
      calories = cal;
      description = desc;
      name = itemName;
      price = itemPrice;
      timeCost = itemTimeCost;
      availible = true;
   }

   MenuItem(const MenuItem & cpy) : calories(cpy.calories), description(cpy.description), name(cpy.name), price(cpy.price), timeCost(cpy.timeCost), availible(cpy.availible) { }
   
   void addOption(Option* newOption)
   {
      options.push_back(newOption);
   }

   void removeOption(int index)
   {
      options.erase(options.begin() + index);
   }

   void updateName(string newName)
   {
      name = newName;
   }

   void MenuItem::updateDescription(string newDesc)
   {
      description = newDesc;
   }

   void updateCalories(int newCal)
   {
      calories = newCal;
   }

   void updatePrice(float newPrice)
   {
      price = newPrice;
   }

   void updatetimeCost(float newTime)
   {
      timeCost = newTime;
   }

   Option* getOption(string name)
   {
      for (int i = 0; i < options.size(); i++)
         if (options[i]->getName() == name) return options[i];
      return NULL;
   }

   int getCalories()
   {
      return calories;
   }

   string getName()
   {
      return name;
   }

   float getPrice()
   {
      return price;
   }

   float getTimeCost()
   {
      return timeCost;
   }

   string MenuItem::getDescription()
   {
      return description;
   }

   int getOptionsListSize()
   {
      return options.size();
   }

   bool operator< (const MenuItem & compareFrom) const
   {
      return name < compareFrom.name;
   }
};