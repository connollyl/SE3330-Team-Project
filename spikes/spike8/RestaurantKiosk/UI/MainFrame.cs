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
   public partial class MainFrame : Form
   {
      public MainFrame()
      {
         InitializeComponent();
      }

      private void MainFrame_Load(object sender, EventArgs e)
      {
        // LoginForm loginChild = new LoginForm();
         FormController formControl = new FormController(this);

         //loginChild.addController(formControl);

         //loginChild.MdiParent = this;

         //formControl.showLoginForm();
      }
   }
}
