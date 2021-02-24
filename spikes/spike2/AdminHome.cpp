#include "AdminHome.h"

using namespace System;
using namespace System::Windows::Forms;

[STAThread]
int main() {
   Application::EnableVisualStyles();
   Application::SetCompatibleTextRenderingDefault(false);

   SE3330_Project::AdminHome form;
   Application::Run(%form);
}

