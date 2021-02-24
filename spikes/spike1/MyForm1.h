#pragma once

namespace Test2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm1
	/// </summary>
	public ref class MyForm1 : public System::Windows::Forms::Form
	{
	public:
		MyForm1(void)
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
		~MyForm1()
		{
			if (components)
			{
				delete components;
			}
		}
   private: System::Windows::Forms::Panel^  panel1;
   protected:
   private: System::Windows::Forms::Button^  button3;


   private: System::Windows::Forms::Button^  button2;
   private: System::Windows::Forms::GroupBox^  grpBx_Sides;

   private: System::Windows::Forms::Button^  button1;
   private: System::Windows::Forms::GroupBox^  grpBx_Drinks;

   private: System::Windows::Forms::Panel^  panel2;
   private: System::Windows::Forms::Button^  button4;
   private: System::Windows::Forms::TableLayoutPanel^  tlp_Meals;
   private: System::Windows::Forms::Button^  button6;
   private: System::Windows::Forms::Button^  button7;
   private: System::Windows::Forms::Button^  button5;
   private: System::Windows::Forms::Label^  label1;
   private: System::Windows::Forms::ListBox^  listBox1;
   private: System::Windows::Forms::Button^  button9;
   private: System::Windows::Forms::Button^  button8;
   private: System::Windows::Forms::TextBox^  textBox1;
   private: System::Windows::Forms::Button^  button10;
   private: System::Windows::Forms::ListView^  listView1;
   private: System::Windows::Forms::ColumnHeader^  Items;
   private: System::Windows::Forms::ColumnHeader^  Price;

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
         System::Windows::Forms::ListViewGroup^  listViewGroup1 = (gcnew System::Windows::Forms::ListViewGroup(L"Meals", System::Windows::Forms::HorizontalAlignment::Left));
         System::Windows::Forms::ListViewGroup^  listViewGroup2 = (gcnew System::Windows::Forms::ListViewGroup(L"Drinks", System::Windows::Forms::HorizontalAlignment::Left));
         System::Windows::Forms::ListViewGroup^  listViewGroup3 = (gcnew System::Windows::Forms::ListViewGroup(L"Sides", System::Windows::Forms::HorizontalAlignment::Left));
         System::Windows::Forms::ListViewItem^  listViewItem1 = (gcnew System::Windows::Forms::ListViewItem(gcnew cli::array< System::String^  >(2) {
            L"Burger",
               L"$6.99"
         }, -1));
         System::Windows::Forms::ListViewItem^  listViewItem2 = (gcnew System::Windows::Forms::ListViewItem(gcnew cli::array< System::String^  >(2) {
            L"+Lettuce",
               L"$0.25"
         }, -1));
         System::Windows::Forms::ListViewItem^  listViewItem3 = (gcnew System::Windows::Forms::ListViewItem(gcnew cli::array< System::String^  >(2) {
            L"Pizza",
               L"$11.99"
         }, -1));
         System::Windows::Forms::ListViewItem^  listViewItem4 = (gcnew System::Windows::Forms::ListViewItem(gcnew cli::array< System::String^  >(2) {
            L"Pepsi",
               L"$0.99"
         }, -1));
         System::Windows::Forms::ListViewItem^  listViewItem5 = (gcnew System::Windows::Forms::ListViewItem(gcnew cli::array< System::String^  >(2) {
            L"Fried Pickles",
               L"$3.99"
         }, -1));
         this->panel1 = (gcnew System::Windows::Forms::Panel());
         this->tlp_Meals = (gcnew System::Windows::Forms::TableLayoutPanel());
         this->button6 = (gcnew System::Windows::Forms::Button());
         this->button7 = (gcnew System::Windows::Forms::Button());
         this->button3 = (gcnew System::Windows::Forms::Button());
         this->button2 = (gcnew System::Windows::Forms::Button());
         this->grpBx_Sides = (gcnew System::Windows::Forms::GroupBox());
         this->button10 = (gcnew System::Windows::Forms::Button());
         this->button1 = (gcnew System::Windows::Forms::Button());
         this->grpBx_Drinks = (gcnew System::Windows::Forms::GroupBox());
         this->button4 = (gcnew System::Windows::Forms::Button());
         this->panel2 = (gcnew System::Windows::Forms::Panel());
         this->listView1 = (gcnew System::Windows::Forms::ListView());
         this->Items = (gcnew System::Windows::Forms::ColumnHeader());
         this->Price = (gcnew System::Windows::Forms::ColumnHeader());
         this->textBox1 = (gcnew System::Windows::Forms::TextBox());
         this->button9 = (gcnew System::Windows::Forms::Button());
         this->button8 = (gcnew System::Windows::Forms::Button());
         this->listBox1 = (gcnew System::Windows::Forms::ListBox());
         this->button5 = (gcnew System::Windows::Forms::Button());
         this->label1 = (gcnew System::Windows::Forms::Label());
         this->panel1->SuspendLayout();
         this->tlp_Meals->SuspendLayout();
         this->grpBx_Sides->SuspendLayout();
         this->grpBx_Drinks->SuspendLayout();
         this->panel2->SuspendLayout();
         this->SuspendLayout();
         // 
         // panel1
         // 
         this->panel1->AutoSize = true;
         this->panel1->Controls->Add(this->tlp_Meals);
         this->panel1->Controls->Add(this->button3);
         this->panel1->Controls->Add(this->button2);
         this->panel1->Controls->Add(this->grpBx_Sides);
         this->panel1->Controls->Add(this->button1);
         this->panel1->Controls->Add(this->grpBx_Drinks);
         this->panel1->Location = System::Drawing::Point(308, 226);
         this->panel1->Name = L"panel1";
         this->panel1->Size = System::Drawing::Size(564, 360);
         this->panel1->TabIndex = 0;
         // 
         // tlp_Meals
         // 
         this->tlp_Meals->ColumnCount = 6;
         this->tlp_Meals->ColumnStyles->Add((gcnew System::Windows::Forms::ColumnStyle(System::Windows::Forms::SizeType::Percent, 46.64311F)));
         this->tlp_Meals->ColumnStyles->Add((gcnew System::Windows::Forms::ColumnStyle(System::Windows::Forms::SizeType::Percent, 53.35689F)));
         this->tlp_Meals->ColumnStyles->Add((gcnew System::Windows::Forms::ColumnStyle(System::Windows::Forms::SizeType::Absolute, 113)));
         this->tlp_Meals->ColumnStyles->Add((gcnew System::Windows::Forms::ColumnStyle(System::Windows::Forms::SizeType::Absolute, 95)));
         this->tlp_Meals->ColumnStyles->Add((gcnew System::Windows::Forms::ColumnStyle(System::Windows::Forms::SizeType::Absolute, 84)));
         this->tlp_Meals->ColumnStyles->Add((gcnew System::Windows::Forms::ColumnStyle(System::Windows::Forms::SizeType::Absolute, 56)));
         this->tlp_Meals->Controls->Add(this->button6, 0, 0);
         this->tlp_Meals->Controls->Add(this->button7, 1, 0);
         this->tlp_Meals->Location = System::Drawing::Point(3, 244);
         this->tlp_Meals->Name = L"tlp_Meals";
         this->tlp_Meals->RowCount = 2;
         this->tlp_Meals->RowStyles->Add((gcnew System::Windows::Forms::RowStyle(System::Windows::Forms::SizeType::Percent, 50)));
         this->tlp_Meals->RowStyles->Add((gcnew System::Windows::Forms::RowStyle(System::Windows::Forms::SizeType::Percent, 50)));
         this->tlp_Meals->Size = System::Drawing::Size(558, 113);
         this->tlp_Meals->TabIndex = 0;
         // 
         // button6
         // 
         this->button6->Location = System::Drawing::Point(3, 3);
         this->button6->Name = L"button6";
         this->button6->Size = System::Drawing::Size(75, 23);
         this->button6->TabIndex = 0;
         this->button6->Text = L"Burger";
         this->button6->UseVisualStyleBackColor = true;
         // 
         // button7
         // 
         this->button7->Location = System::Drawing::Point(100, 3);
         this->button7->Name = L"button7";
         this->button7->Size = System::Drawing::Size(75, 23);
         this->button7->TabIndex = 1;
         this->button7->Text = L"Pizza";
         this->button7->UseVisualStyleBackColor = true;
         // 
         // button3
         // 
         this->button3->Location = System::Drawing::Point(3, 215);
         this->button3->Name = L"button3";
         this->button3->Size = System::Drawing::Size(90, 23);
         this->button3->TabIndex = 5;
         this->button3->Text = L"Meals";
         this->button3->UseVisualStyleBackColor = true;
         this->button3->Click += gcnew System::EventHandler(this, &MyForm1::button3_Click);
         // 
         // button2
         // 
         this->button2->Location = System::Drawing::Point(321, 3);
         this->button2->Name = L"button2";
         this->button2->Size = System::Drawing::Size(75, 23);
         this->button2->TabIndex = 3;
         this->button2->Text = L"Sides";
         this->button2->UseVisualStyleBackColor = true;
         this->button2->Click += gcnew System::EventHandler(this, &MyForm1::button2_Click);
         // 
         // grpBx_Sides
         // 
         this->grpBx_Sides->Controls->Add(this->button10);
         this->grpBx_Sides->Location = System::Drawing::Point(321, 32);
         this->grpBx_Sides->Name = L"grpBx_Sides";
         this->grpBx_Sides->Size = System::Drawing::Size(229, 177);
         this->grpBx_Sides->TabIndex = 2;
         this->grpBx_Sides->TabStop = false;
         this->grpBx_Sides->Text = L"Sides";
         // 
         // button10
         // 
         this->button10->Location = System::Drawing::Point(7, 20);
         this->button10->Name = L"button10";
         this->button10->Size = System::Drawing::Size(75, 23);
         this->button10->TabIndex = 0;
         this->button10->Text = L"Fried Pickles";
         this->button10->UseVisualStyleBackColor = true;
         // 
         // button1
         // 
         this->button1->Location = System::Drawing::Point(3, 3);
         this->button1->Name = L"button1";
         this->button1->Size = System::Drawing::Size(75, 23);
         this->button1->TabIndex = 1;
         this->button1->Text = L"Drinks";
         this->button1->UseVisualStyleBackColor = true;
         this->button1->Click += gcnew System::EventHandler(this, &MyForm1::button1_Click);
         // 
         // grpBx_Drinks
         // 
         this->grpBx_Drinks->Controls->Add(this->button4);
         this->grpBx_Drinks->Location = System::Drawing::Point(3, 32);
         this->grpBx_Drinks->Name = L"grpBx_Drinks";
         this->grpBx_Drinks->Size = System::Drawing::Size(211, 177);
         this->grpBx_Drinks->TabIndex = 0;
         this->grpBx_Drinks->TabStop = false;
         this->grpBx_Drinks->Text = L"Drinks";
         // 
         // button4
         // 
         this->button4->Location = System::Drawing::Point(6, 19);
         this->button4->Name = L"button4";
         this->button4->Size = System::Drawing::Size(75, 23);
         this->button4->TabIndex = 0;
         this->button4->Text = L"Pepsi";
         this->button4->UseVisualStyleBackColor = true;
         // 
         // panel2
         // 
         this->panel2->AutoSize = true;
         this->panel2->Controls->Add(this->listView1);
         this->panel2->Controls->Add(this->textBox1);
         this->panel2->Controls->Add(this->button9);
         this->panel2->Controls->Add(this->button8);
         this->panel2->Controls->Add(this->listBox1);
         this->panel2->Controls->Add(this->button5);
         this->panel2->Controls->Add(this->label1);
         this->panel2->Location = System::Drawing::Point(878, 226);
         this->panel2->Name = L"panel2";
         this->panel2->Size = System::Drawing::Size(438, 360);
         this->panel2->TabIndex = 1;
         // 
         // listView1
         // 
         this->listView1->Columns->AddRange(gcnew cli::array< System::Windows::Forms::ColumnHeader^  >(2) { this->Items, this->Price });
         listViewGroup1->Header = L"Meals";
         listViewGroup1->Name = L"Meals";
         listViewGroup2->Header = L"Drinks";
         listViewGroup2->Name = L"Drinks";
         listViewGroup3->Header = L"Sides";
         listViewGroup3->Name = L"Sides";
         this->listView1->Groups->AddRange(gcnew cli::array< System::Windows::Forms::ListViewGroup^  >(3) {
            listViewGroup1, listViewGroup2,
               listViewGroup3
         });
         listViewItem1->Group = listViewGroup1;
         listViewItem2->Group = listViewGroup1;
         listViewItem3->Group = listViewGroup1;
         listViewItem4->Group = listViewGroup2;
         listViewItem5->Group = listViewGroup3;
         this->listView1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ListViewItem^  >(5) {
            listViewItem1, listViewItem2,
               listViewItem3, listViewItem4, listViewItem5
         });
         this->listView1->Location = System::Drawing::Point(200, 21);
         this->listView1->MultiSelect = false;
         this->listView1->Name = L"listView1";
         this->listView1->Size = System::Drawing::Size(226, 225);
         this->listView1->TabIndex = 6;
         this->listView1->UseCompatibleStateImageBehavior = false;
         this->listView1->View = System::Windows::Forms::View::Details;
         // 
         // Items
         // 
         this->Items->Text = L"Items";
         this->Items->Width = 146;
         // 
         // Price
         // 
         this->Price->Text = L"Price";
         this->Price->Width = 72;
         // 
         // textBox1
         // 
         this->textBox1->Location = System::Drawing::Point(7, 249);
         this->textBox1->Name = L"textBox1";
         this->textBox1->Size = System::Drawing::Size(186, 20);
         this->textBox1->TabIndex = 5;
         this->textBox1->Text = L"Sub-Total:                     $10.49";
         // 
         // button9
         // 
         this->button9->Location = System::Drawing::Point(7, 279);
         this->button9->Name = L"button9";
         this->button9->Size = System::Drawing::Size(75, 23);
         this->button9->TabIndex = 4;
         this->button9->Text = L"Edit";
         this->button9->UseVisualStyleBackColor = true;
         // 
         // button8
         // 
         this->button8->Location = System::Drawing::Point(118, 279);
         this->button8->Name = L"button8";
         this->button8->Size = System::Drawing::Size(75, 23);
         this->button8->TabIndex = 3;
         this->button8->Text = L"Remove";
         this->button8->UseVisualStyleBackColor = true;
         // 
         // listBox1
         // 
         this->listBox1->FormattingEnabled = true;
         this->listBox1->Items->AddRange(gcnew cli::array< System::Object^  >(5) {
            L"Burger\t\t $6.99", L"   +Lettuce\t       +$0.25",
               L"   +Tomato\t       +$0.25", L"Coors Light\t $2.50", L"   +Large\t\t       +$0.50"
         });
         this->listBox1->Location = System::Drawing::Point(7, 21);
         this->listBox1->MultiColumn = true;
         this->listBox1->Name = L"listBox1";
         this->listBox1->Size = System::Drawing::Size(186, 225);
         this->listBox1->TabIndex = 2;
         // 
         // button5
         // 
         this->button5->Location = System::Drawing::Point(7, 308);
         this->button5->Name = L"button5";
         this->button5->Size = System::Drawing::Size(187, 49);
         this->button5->TabIndex = 1;
         this->button5->Text = L"Checkout";
         this->button5->UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this->label1->AutoSize = true;
         this->label1->Location = System::Drawing::Point(4, 4);
         this->label1->Name = L"label1";
         this->label1->Size = System::Drawing::Size(72, 13);
         this->label1->TabIndex = 0;
         this->label1->Text = L"Cart Summary";
         // 
         // MyForm1
         // 
         this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
         this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
         this->ClientSize = System::Drawing::Size(1600, 900);
         this->Controls->Add(this->panel2);
         this->Controls->Add(this->panel1);
         this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
         this->Name = L"MyForm1";
         this->ShowIcon = false;
         this->ShowInTaskbar = false;
         this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
         this->Text = L"MyForm1";
         this->WindowState = System::Windows::Forms::FormWindowState::Maximized;
         this->Load += gcnew System::EventHandler(this, &MyForm1::MyForm1_Load);
         this->panel1->ResumeLayout(false);
         this->tlp_Meals->ResumeLayout(false);
         this->grpBx_Sides->ResumeLayout(false);
         this->grpBx_Drinks->ResumeLayout(false);
         this->panel2->ResumeLayout(false);
         this->panel2->PerformLayout();
         this->ResumeLayout(false);
         this->PerformLayout();

      }
#pragma endregion
   private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
      grpBx_Drinks->Visible = !grpBx_Drinks->Visible;
   }
   private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) {
      tlp_Meals->Visible = !tlp_Meals->Visible;
   }
   private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
      grpBx_Sides->Visible = !grpBx_Sides->Visible;
   }
   private: System::Void MyForm1_Load(System::Object^  sender, System::EventArgs^  e) {
      grpBx_Drinks->Visible = false;
      tlp_Meals->Visible = false;
      grpBx_Sides->Visible = false;
   }

};
}
