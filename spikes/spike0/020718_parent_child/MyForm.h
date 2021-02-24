#pragma once
#include "MyForm1.h"
namespace RestaurantManagement {

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
   private: System::Windows::Forms::MenuStrip^  menuStrip1;
   protected:
   private: System::Windows::Forms::ToolStripMenuItem^  fILEToolStripMenuItem;
   private: System::Windows::Forms::ToolStripMenuItem^  bfdzbfdToolStripMenuItem;

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
         this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
         this->fILEToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
         this->bfdzbfdToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
         this->menuStrip1->SuspendLayout();
         this->SuspendLayout();
         // 
         // menuStrip1
         // 
         this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {
            this->fILEToolStripMenuItem,
               this->bfdzbfdToolStripMenuItem
         });
         this->menuStrip1->Location = System::Drawing::Point(0, 0);
         this->menuStrip1->Name = L"menuStrip1";
         this->menuStrip1->Size = System::Drawing::Size(819, 24);
         this->menuStrip1->TabIndex = 1;
         this->menuStrip1->Text = L"menuStrip1";
         // 
         // fILEToolStripMenuItem
         // 
         this->fILEToolStripMenuItem->Name = L"fILEToolStripMenuItem";
         this->fILEToolStripMenuItem->Size = System::Drawing::Size(40, 20);
         this->fILEToolStripMenuItem->Text = L"FILE";
         // 
         // bfdzbfdToolStripMenuItem
         // 
         this->bfdzbfdToolStripMenuItem->Name = L"bfdzbfdToolStripMenuItem";
         this->bfdzbfdToolStripMenuItem->Size = System::Drawing::Size(60, 20);
         this->bfdzbfdToolStripMenuItem->Text = L"bfdzbfd";
         // 
         // MyForm
         // 
         this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
         this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
         this->ClientSize = System::Drawing::Size(819, 362);
         this->Controls->Add(this->menuStrip1);
         this->IsMdiContainer = true;
         this->MainMenuStrip = this->menuStrip1;
         this->Name = L"MyForm";
         this->Text = L"MyForm";
         this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
         this->menuStrip1->ResumeLayout(false);
         this->menuStrip1->PerformLayout();
         this->ResumeLayout(false);
         this->PerformLayout();
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
