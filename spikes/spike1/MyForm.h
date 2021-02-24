#pragma once
#include "MyForm1.h"

namespace Test2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
         this->SuspendLayout();
         // 
         // MyForm
         // 
         this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
         this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
         this->ClientSize = System::Drawing::Size(657, 356);
         this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
         this->IsMdiContainer = true;
         this->Name = L"MyForm";
         this->ShowIcon = false;
         this->ShowInTaskbar = false;
         this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
         this->Text = L"MyForm";
         this->WindowState = System::Windows::Forms::FormWindowState::Maximized;
         this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
         this->ResumeLayout(false);

      }
#pragma endregion
   private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) {
      MyForm1^ newMDIChild = gcnew MyForm1();
      // Set the Parent Form of the Child window.  
      newMDIChild->MdiParent = this;
      // Display the new form.  
      newMDIChild->Show();
   }
   };
}
