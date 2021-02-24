//---------------------------------------------------------------------
// Name:    Spencer, Dustin, Nick, Daniel, Logan
// Project: Restaurant Kiosk Software
// Purpose: Displays all current uncompleted orders on the form,
//          and removes the order upon completion, also marking
//          the order as completed.
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantKiosk
{
   public partial class KitchenForm : Form
   {
      private const int RTB0 = 0, RTB1 = 1, RTB2 = 2, RTB3 = 3, RTB4 = 4;
      private KitchenController controller = new KitchenController();
      private List<System.Windows.Forms.RichTextBox> orderslots = new List<System.Windows.Forms.RichTextBox>();
      private List<System.Windows.Forms.Button> completeButtons = new List<System.Windows.Forms.Button>();
      protected FormController formController;

      public KitchenForm()
      {
         InitializeComponent();
         orderslots.Add(rchTxtbBx_order0);
         orderslots.Add(rchTxtbBx_order1);
         orderslots.Add(rchTxtbBx_order2);
         orderslots.Add(rchTxtbBx_order3);
         orderslots.Add(rchTxtbBx_order4);
         completeButtons.Add(btn_completeorder0);
         completeButtons.Add(btn_completeorder1);
         completeButtons.Add(btn_completeorder2);
         completeButtons.Add(btn_completeorder3);
         completeButtons.Add(btn_completeorder4);
      }

      //---------------------------------------------------------------
      // Assigns a form controller to manage the form
      //---------------------------------------------------------------
      public void addController(FormController controller)
      {
         formController = controller;
      }

      //---------------------------------------------------------------
      // Default load: loads all orders starting at index 0
      //---------------------------------------------------------------
      private void OrderViewForm_Load(object sender, EventArgs e)
      {
         ReloadOrders(RTB0);
      }

      //---------------------------------------------------------------
      // Displays the login form
      //---------------------------------------------------------------
      private void btn_logout_Click(object sender, EventArgs e)
      {
         formController.showLoginForm();
      }

      //---------------------------------------------------------------
      // Reloads all orders beginning at index 0
      //---------------------------------------------------------------
      private void btn_completeorder0_Click(object sender, EventArgs e)
      {
         ClearBoxesAbove(RTB0);
         controller.CompleteOrder(RTB0);
         ReloadOrders(RTB0);
      }

      //---------------------------------------------------------------
      // Reloads all orders beginning at index 1
      //---------------------------------------------------------------
      private void btn_completeorder1_Click(object sender, EventArgs e)
      {
         ClearBoxesAbove(RTB1);
         controller.CompleteOrder(RTB1);
         ReloadOrders(RTB1);
      }

      //---------------------------------------------------------------
      // Reloads all orders beginning at index 2
      //---------------------------------------------------------------
      private void btn_completeorder2_Click(object sender, EventArgs e)
      {
         ClearBoxesAbove(RTB2);
         controller.CompleteOrder(RTB2);
         ReloadOrders(RTB2);
      }

      //---------------------------------------------------------------
      // Reloads all orders beginning at index 3
      //---------------------------------------------------------------
      private void btn_completeorder3_Click(object sender, EventArgs e)
      {
         ClearBoxesAbove(RTB3);
         controller.CompleteOrder(RTB3);
         ReloadOrders(RTB3);
      }

      //---------------------------------------------------------------
      // Reloads all orders beginning at index 4
      //---------------------------------------------------------------
      private void btn_completeorder4_Click(object sender, EventArgs e)
      {
         ClearBoxesAbove(RTB4);
         controller.CompleteOrder(RTB4);
         ReloadOrders(RTB4);
      }

      //---------------------------------------------------------------
      // Prints all orders, starting at the specified index, until
      // all fields in the form are filled or until no more orders
      // can be loaded
      //---------------------------------------------------------------
      private void ReloadOrders(int start)
      {
         for (int i = start; i < orderslots.Count &&
            i < controller.FetchOrders().Count; i++)
         {
            orderslots[i].Text = controller.PrintOrder(i);
         }

         ShowButtons();
      }

      //---------------------------------------------------------------
      // Displays 'complete order' buttons only for fields
      // with visible text
      //---------------------------------------------------------------
      private void ShowButtons()
      {
         for(int i = 0; i < completeButtons.Count; i++)
         {
            if (orderslots[i].Text.Equals(""))
               completeButtons[i].Hide();
            else
               completeButtons[i].Show();
         }

      }

      //---------------------------------------------------------------
      // Empties the text contents from all text fields beyond
      // the given index
      //---------------------------------------------------------------
      private void ClearBoxesAbove(int index)
      {
         for (int i = index; i < orderslots.Count; i++)
            orderslots[i].Clear();
      }
   }
}
