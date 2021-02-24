#include "stdafx.h"
#include "CppUnitTest.h"
#include "../MenuItem.h"
#include "../Options.h"
#include "../CustomItem.h"
#include <cassert>
#include <map>

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace MenuItemTest
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(Test_OptionList)
		{
         MenuItem *testItem = new MenuItem(100, "Delicious food.", "Badger Burger", 9.95f, 10.0f);
         
         testItem->addOption(new Option("Lettuce", .50f, 23));

         //Find lettuce and no tomatos
         assert((testItem->getOption("Lettuce"))->getName() == "Lettuce");
         assert((testItem->getOption("Tomato")) == NULL);

         //no lettuce after removing it 
         testItem->removeOption(0);
         assert((testItem->getOption("Lettuce")) == NULL);
         
		}

      TEST_METHOD(Test_ClassFunctionality)
      {
         MenuItem *testItem = new MenuItem(100, "Delicious food.", "Badger Burger", 9.95f, 10.0f);
         MenuItem *testItem2 = new MenuItem(50, "Horrible food.", "Salad", 19.95f, 5.0f);

         testItem->updateCalories(105);
         assert(testItem->getCalories() == 105);

         testItem->updateName("New Burger Name");
         assert(testItem->getName() == "New Burger Name");

         testItem->updateDescription("New Burger Description");
         assert(testItem->getDescription() == "New Burger Description");

         testItem->updatePrice(2.43f);
         assert(testItem->getPrice() == 2.43f);

         testItem->updatetimeCost(12.0f);
         assert(testItem->getTimeCost() == 12.0f);
      }

      TEST_METHOD(Test_CustomOrder)
      {
         MenuItem *testItem = new MenuItem(100, "Delicious food.", "Badger Burger", 9.95f, 10.0f);
         MenuItem *testItem2 = new MenuItem(50, "Horrible food.", "Salad", 19.95f, 5.0f);

         testItem->addOption(new Option("Lettuce", .50f, 23));
         testItem->addOption(new Option("Bacon", 1.50f, 100));
         testItem->addOption(new Option("Cheese", .75f, 50));
         vector<CustomItem*> ci;
         
         ci.push_back(new CustomItem(*testItem));
         ci.push_back(new CustomItem(*testItem2));
         int* selOp = new int[3]{ 0, 1, 0 };
         ci[0]->updateSelectedOptions(selOp);
         assert(ci[0]->getSelectedItems()[1] == 1);
      }

	};
}