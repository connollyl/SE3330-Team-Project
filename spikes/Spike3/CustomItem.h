#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <map>
#include "Options.h"
#include "MenuItem.h"

using namespace std;

class CustomItem : public MenuItem
{
private:
   vector<Option*> options;
   int* selectedOptions;
   
public:
   CustomItem()
   {

   }
   CustomItem(MenuItem& selectedMenuItem) : MenuItem(selectedMenuItem)
   {
      selectedOptions = new int[this->getOptionsListSize()];
   }

   void updateSelectedOptions(int* oList)
   {
      delete[] selectedOptions;
      selectedOptions = oList;
   }

   int* getSelectedItems()
   {
      return selectedOptions;
   }
};