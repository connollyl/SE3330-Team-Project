using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace buttonResearch
{
  
   public partial class Form1 : Form
   {
      const int MAX_SIZE = 90;
      const int perRow = 9;
      const int perCol = 9;
      const int spacingY = 50;
      const int spacingX = 90;
      OrderController orderC = new OrderController();
      AdminController adminC = new AdminController();
      List<MenuItem> items = new List<MenuItem>();
      public Form1()
      {
         InitializeComponent();
         for (int i = 0; i < MAX_SIZE; i++)
         {
            adminC.addMenuItem(i, i.ToString(), (i+1).ToString(), i, i);
            items.Add(adminC.loadMenuItem(i));
         }
         initButtons();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
      }
      private void initButtons()
      {
         List<Button> buttons = new List<Button>();
         for (int i = 0; i < items.Count; i++)
         {
            Button b = new Button();
            b.Text = items[i].getName();
            b.Name = "btn_" + items[i].getName();
            b.Location = determineLocation(i);
            buttons.Add(b);
            this.Controls.Add(buttons[i]);
         }
      }
      private Point determineLocation(int index)
      {
         //todo
         Point p = new Point(0, 0);
         p.X = (index % perRow) * spacingX;
         p.Y = (index / perCol) * spacingY;
         return p;
      } 
   }
}
