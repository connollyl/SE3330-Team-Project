using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantKiosk.Controllers
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

      /*
       * Updates the current menu
       */
      public List<MenuItem> getMenu()
      {
         return menu;
      }

      /*
       * True if the done stack is empty
       */
      public bool DoneIsEmpty()
      {
         return done_commands.Count == 0;
      }

      /*
       * True if the undone stack is empty, false otherwise.
       */
      public bool UndoneIsEmpty()
      {
         return undone_commands.Count == 0;
      }

      /*
       * Processes the redo command by poping from the undone
       * stack and unexecuting.
       */
      public void redo(List<MenuItem> m)
      {
         menu = m;
         if (!UndoneIsEmpty())
         {
            Command to_redo = undone_commands.Pop();
            //to_redo.UpdateMenu(restaurantMenu);
            to_redo.un_execute();
            done_commands.Push(to_redo);
         }
      }

      /*
       * Processes undo from the done_commands stack.
       */
      public void undo(List<MenuItem> m)
      {
         menu = m;
         if (!DoneIsEmpty())
         {
            Command to_undo = done_commands.Pop();
            // to_undo.UpdateMenu(restaurantMenu);
            to_undo.un_execute();
            undone_commands.Push(to_undo);
         }
      }
   }

   /*
    * Abstract class to implement command pattern for adding and removing menu items.
    */
   public abstract class Command
   {
      protected AdminHistory history;
      protected string info;

      public Command(List<MenuItem> items)
      {
         history = new AdminHistory(items);
         history.menu = items;
      }

      public void UpdateMenu(List<MenuItem> items)
      {
         history.menu = items;
      }

      /*
       * Abstract mehtods to be defined and commented in child classes
       */
      public abstract void execute();
      public abstract void un_execute();
      public abstract string see_details();
   }

   /*
    * Handles adding a new item to the menu through command pattern.
    */
   public class UpdateCommand : Command
   {
      private MenuItem itemAdded;

      /*
       * Sets itemAdded and calls the base class with the list.
       */
      public UpdateCommand(List<MenuItem> items, MenuItem item) : base(items)
      {
         itemAdded = item;
      }

      /*
       * Returns the name of the item for user clarification
       */
      public override string see_details()
      {
         return base.info;
      }

      /*
       * Adds the new item to the menu
       */
      public override void execute()
      {
         base.history.menu.Add(itemAdded);
         base.info = "Removes " + itemAdded.nameAtt;
      }

      /*
       * Removes the item from the menu.
       */
      public override void un_execute()
      {
         base.history.menu.Remove(itemAdded);
         base.info = "Adds " + itemAdded.nameAtt;
      }
   }

   /*
    * Handles removing an existing menu item from the menu using command pattern.
    */
   public class RemoveCommand : Command
   {
      private MenuItem itemRemoved;

      /*
       * Constructor sets itemRemoved and calls the base class.
       */
      public RemoveCommand(List<MenuItem> items, MenuItem item) : base(items)
      {
         itemRemoved = item;
      }

      /*
       * Returns the name of the item for user clarification
       */
      public override string see_details()
      {
         return base.info;
      }

      /*
       * Removes the item from the menu.
       */
      public override void execute()
      {
         base.history.menu.Remove(itemRemoved);
         base.info = "Adds " + itemRemoved.nameAtt;
      }

      /*
       * Adds the item back to the menu.
       */
      public override void un_execute()
      {
         base.history.menu.Add(itemRemoved);
         base.info = "Removes " + itemRemoved.nameAtt;
      }

   }
}
