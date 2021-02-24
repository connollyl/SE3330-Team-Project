//---------------------------------------------------------------------
// Name:    Spencer, Dustin, Nick, Daniel, Logan
// Project: Restaurant Kiosk Software
// Purpose: Admin history serves as the reciever for the command
//          pattern.
//          The classes for commands are also placed in this file.
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk
{
   public class AdminHistory
   {
      public Stack<Command> done_commands;
      public Stack<Command> undone_commands;
      public List<MenuItem> menu;
      public AdminHistory(List<MenuItem> m)
      {
         done_commands = new Stack<Command>();
         undone_commands = new Stack<Command>();
         menu = m;
      }

      // ----------------------------------------------------------
      // Updates the current menu
      // ----------------------------------------------------------
      public List<MenuItem> getMenu()
      {
         return menu;
      }

      // ----------------------------------------------------------
      // True if the done stack is empty
      // ----------------------------------------------------------
      public bool DoneIsEmpty()
      {
         return done_commands.Count == 0;
      }

      // ----------------------------------------------------------
      // Adds an item to the list of menu items
      // ----------------------------------------------------------
      public void addItem(MenuItem item)
      {
         menu.Add(item);

      }

      // ----------------------------------------------------------
      // Removes an item from the menu 
      // ----------------------------------------------------------
      public void removeItem(MenuItem item)
      {
         menu.Remove(item);
      }

      // ----------------------------------------------------------
      // True if the undone stack is empty, false otherwise.
      // ----------------------------------------------------------
      public bool UndoneIsEmpty()
      {
         return undone_commands.Count == 0;
      }

      // ----------------------------------------------------------
      // Processes the redo command by poping from the undone
      // stack and unexecuting.
      // ----------------------------------------------------------
      public void redo(List<MenuItem> m)
      {
         if (!UndoneIsEmpty())
         {
            Command to_redo = undone_commands.Pop();
            to_redo.execute();
            done_commands.Push(to_redo);
         }
      }

      // ----------------------------------------------------------
      // Processes undo from the done_commands stack.
      // ----------------------------------------------------------
      public void undo(List<MenuItem> m)
      {
         if (!DoneIsEmpty())
         {
            Command to_undo = done_commands.Pop();
            to_undo.un_execute();
            undone_commands.Push(to_undo);
         }
      }
   }

   // -------------------------------------------------------------
   // Abstract class to implement command 
   // pattern for adding and removing menu items.
   // ------------------------------------------------------------- 
   public abstract class Command
   {
      protected AdminHistory history;
      protected string info;

      public Command(List<MenuItem> items, AdminHistory history)
      {
         this.history = history;
         history.menu = items;
      }

      // ----------------------------------------------------------
      // Abstract mehtods to be defined and 
      // commented in child classes
      // ----------------------------------------------------------
      public abstract void execute();
      public abstract void un_execute();
      public abstract string see_details();
   }

   // -------------------------------------------------------------
   // Handles adding a new item to the menu 
   // through command pattern.
   // -------------------------------------------------------------
   public class UpdateCommand : Command
   {
      private MenuItem itemAdded;

      // ----------------------------------------------------------
      // Sets itemAdded and calls the base class 
      //  with the list.
      // ----------------------------------------------------------
      public UpdateCommand(List<MenuItem> items, MenuItem item, AdminHistory history) : base(items, history)
      {
         itemAdded = item;
      }

      // ----------------------------------------------------------
      // Returns the name of the item for user clarification
      // ----------------------------------------------------------
      public override string see_details()
      {
         return base.info;
      }

      // ----------------------------------------------------------
      // Adds the new item to the menu
      // ----------------------------------------------------------
      public override void execute()
      {
         history.addItem(itemAdded);
         base.info = "Removes " + itemAdded.nameAtt;
      }

      // ----------------------------------------------------------
      // Removes the item from the menu.
      // ----------------------------------------------------------
      public override void un_execute()
      {
         history.removeItem(itemAdded);
         base.info = "Adds " + itemAdded.nameAtt;
      }
   }

   // -------------------------------------------------------------
   // Handles removing an existing menu item 
   // from the menu using command pattern.
   // -------------------------------------------------------------
   public class RemoveCommand : Command
   {
      private MenuItem itemRemoved;

      // ----------------------------------------------------------
      // Constructor sets itemRemoved and calls the base class.
      // ----------------------------------------------------------
      public RemoveCommand(List<MenuItem> items, MenuItem item, AdminHistory history) : base(items,history)
      {
         itemRemoved = item;
      }

      // ----------------------------------------------------------
      // Returns the name of the item for user clarification
      // ----------------------------------------------------------
      public override string see_details()
      {
         return base.info;
      }

      // ----------------------------------------------------------
      // Removes the item from the menu.
      // ----------------------------------------------------------
      public override void execute()
      {
         history.removeItem(itemRemoved);
         base.info = "Adds " + itemRemoved.nameAtt;
      }

      // ----------------------------------------------------------
      // Adds the item back to the menu.
      // ----------------------------------------------------------
      public override void un_execute()
      {
         history.addItem(itemRemoved);
         base.info = "Removes " + itemRemoved.nameAtt;
      }

   }
}
