using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantKiosk.Controllers;

namespace RestaurantKiosk
{
   public partial class OrderForm : Form
   {

      FormController formController;
      OrderController orderController;

      public OrderForm()
      {
         InitializeComponent();
      }

      public void addController(FormController controller)
      {
         formController = controller;
      }

      private void OrderForm_Load(object sender, EventArgs e)
      {
         orderController = new OrderController();
         grpBx_meals.Visible = false;
         grpBx_drinks.Visible = false;
         grpBx_sides.Visible = false;
         grpBx_ingredients.Visible = false;
      }

      private void btn_meal_Click(object sender, EventArgs e)
      {
         grpBx_meals.Visible = true;
         grpBx_drinks.Visible = false;
         grpBx_sides.Visible = false;
         grpBx_ingredients.Visible = false;
      }

      private void btn_sides_Click(object sender, EventArgs e)
      {
         grpBx_meals.Visible = false;
         grpBx_drinks.Visible = false;
         grpBx_sides.Visible = true;
         grpBx_ingredients.Visible = false;
      }

      private void btn_drinks_Click(object sender, EventArgs e)
      {
         grpBx_meals.Visible = false;
         grpBx_drinks.Visible = true;
         grpBx_sides.Visible = false;
         grpBx_ingredients.Visible = false;
      }

      private void btn_burger_Click(object sender, EventArgs e)
      {
         grpBx_ingredients.Visible = true;
      }

      private void btn_add_Click(object sender, EventArgs e)
      {
         grpBx_meals.Visible = false;
         grpBx_drinks.Visible = false;
         grpBx_sides.Visible = false;
         grpBx_ingredients.Visible = false;
      }

      private void btn_logout_Click(object sender, EventArgs e)
      {
         formController.showLoginForm();
      }
   }
}
