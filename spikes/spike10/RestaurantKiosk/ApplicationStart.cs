using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantKiosk
{
   static class ApplicationStart
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         LoginForm log = new LoginForm();
         
         log.BackColor = System.Drawing.Color.Transparent;
         Application.Run(log);
      }
   }
}
