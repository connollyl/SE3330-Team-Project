#pragma once

namespace SE3330_Project {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for AdminHome
	/// </summary>
	public ref class AdminHome : public System::Windows::Forms::Form
	{
	public:
		AdminHome(void)
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
		~AdminHome()
		{
			if (components)
			{
				delete components;
			}
		}
   private: System::Windows::Forms::Button^  exit_btn;
   protected:
   private: System::Windows::Forms::Button^  done_btn;
   private: System::Windows::Forms::Label^  Item_name_lbl;
   private: System::Windows::Forms::TextBox^  itemName_txt;

   private: System::Windows::Forms::ComboBox^  category_cb;

   private: System::Windows::Forms::Label^  label1;
   private: System::Windows::Forms::Label^  label2;
   private: System::Windows::Forms::TextBox^  textBox2;
   private: System::Windows::Forms::Label^  description_lbl;
   private: System::Windows::Forms::ListBox^  options_box;
   private: System::Windows::Forms::ListView^  listView1;
   private: System::Windows::Forms::ColumnHeader^  item_header;
   private: System::Windows::Forms::ColumnHeader^  price_header;
   private: System::Windows::Forms::Label^  items_lbl;
   private: System::Windows::Forms::ComboBox^  items_cb;
   private: System::Windows::Forms::Button^  addOption_btn;


   private: System::Windows::Forms::Button^  addItem_btn;

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
         System::Windows::Forms::ListViewItem^  listViewItem1 = (gcnew System::Windows::Forms::ListViewItem(gcnew cli::array< System::String^  >(2) {
            L"Lettuce",
               L"$0.25"
         }, -1));
         System::Windows::Forms::ListViewItem^  listViewItem2 = (gcnew System::Windows::Forms::ListViewItem(gcnew cli::array< System::String^  >(2) {
            L"Bacon",
               L"$1.50"
         }, -1));
         this->exit_btn = (gcnew System::Windows::Forms::Button());
         this->done_btn = (gcnew System::Windows::Forms::Button());
         this->Item_name_lbl = (gcnew System::Windows::Forms::Label());
         this->itemName_txt = (gcnew System::Windows::Forms::TextBox());
         this->category_cb = (gcnew System::Windows::Forms::ComboBox());
         this->label1 = (gcnew System::Windows::Forms::Label());
         this->label2 = (gcnew System::Windows::Forms::Label());
         this->textBox2 = (gcnew System::Windows::Forms::TextBox());
         this->description_lbl = (gcnew System::Windows::Forms::Label());
         this->options_box = (gcnew System::Windows::Forms::ListBox());
         this->listView1 = (gcnew System::Windows::Forms::ListView());
         this->item_header = (gcnew System::Windows::Forms::ColumnHeader());
         this->price_header = (gcnew System::Windows::Forms::ColumnHeader());
         this->items_lbl = (gcnew System::Windows::Forms::Label());
         this->items_cb = (gcnew System::Windows::Forms::ComboBox());
         this->addOption_btn = (gcnew System::Windows::Forms::Button());
         this->addItem_btn = (gcnew System::Windows::Forms::Button());
         this->SuspendLayout();
         // 
         // exit_btn
         // 
         this->exit_btn->Location = System::Drawing::Point(21, 273);
         this->exit_btn->Name = L"exit_btn";
         this->exit_btn->Size = System::Drawing::Size(75, 23);
         this->exit_btn->TabIndex = 0;
         this->exit_btn->Text = L"Exit";
         this->exit_btn->UseVisualStyleBackColor = true;
         this->exit_btn->Click += gcnew System::EventHandler(this, &AdminHome::exit_btn_Click);
         // 
         // done_btn
         // 
         this->done_btn->Location = System::Drawing::Point(310, 273);
         this->done_btn->Name = L"done_btn";
         this->done_btn->Size = System::Drawing::Size(75, 23);
         this->done_btn->TabIndex = 1;
         this->done_btn->Text = L"Done";
         this->done_btn->UseVisualStyleBackColor = true;
         // 
         // Item_name_lbl
         // 
         this->Item_name_lbl->AutoSize = true;
         this->Item_name_lbl->Location = System::Drawing::Point(18, 18);
         this->Item_name_lbl->Name = L"Item_name_lbl";
         this->Item_name_lbl->Size = System::Drawing::Size(58, 13);
         this->Item_name_lbl->TabIndex = 2;
         this->Item_name_lbl->Text = L"Item Name";
         // 
         // itemName_txt
         // 
         this->itemName_txt->Enabled = false;
         this->itemName_txt->Location = System::Drawing::Point(82, 15);
         this->itemName_txt->Name = L"itemName_txt";
         this->itemName_txt->Size = System::Drawing::Size(91, 20);
         this->itemName_txt->TabIndex = 3;
         // 
         // category_cb
         // 
         this->category_cb->FormattingEnabled = true;
         this->category_cb->Items->AddRange(gcnew cli::array< System::Object^  >(2) { L"Food Items", L"Drinks" });
         this->category_cb->Location = System::Drawing::Point(21, 91);
         this->category_cb->Name = L"category_cb";
         this->category_cb->Size = System::Drawing::Size(111, 21);
         this->category_cb->TabIndex = 4;
         this->category_cb->Text = L"<Select Category>";
         // 
         // label1
         // 
         this->label1->AutoSize = true;
         this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
            static_cast<System::Byte>(0)));
         this->label1->Location = System::Drawing::Point(18, 64);
         this->label1->Name = L"label1";
         this->label1->Size = System::Drawing::Size(57, 13);
         this->label1->TabIndex = 6;
         this->label1->Text = L"Category";
         // 
         // label2
         // 
         this->label2->AutoSize = true;
         this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
            static_cast<System::Byte>(0)));
         this->label2->Location = System::Drawing::Point(283, 64);
         this->label2->Name = L"label2";
         this->label2->Size = System::Drawing::Size(95, 13);
         this->label2->TabIndex = 7;
         this->label2->Text = L"Custom Options";
         // 
         // textBox2
         // 
         this->textBox2->Enabled = false;
         this->textBox2->Location = System::Drawing::Point(21, 247);
         this->textBox2->Name = L"textBox2";
         this->textBox2->Size = System::Drawing::Size(364, 20);
         this->textBox2->TabIndex = 8;
         // 
         // description_lbl
         // 
         this->description_lbl->AutoSize = true;
         this->description_lbl->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
            static_cast<System::Byte>(0)));
         this->description_lbl->Location = System::Drawing::Point(18, 219);
         this->description_lbl->Name = L"description_lbl";
         this->description_lbl->Size = System::Drawing::Size(71, 13);
         this->description_lbl->TabIndex = 9;
         this->description_lbl->Text = L"Description";
         // 
         // options_box
         // 
         this->options_box->FormattingEnabled = true;
         this->options_box->Items->AddRange(gcnew cli::array< System::Object^  >(1) { L"<New Option>" });
         this->options_box->Location = System::Drawing::Point(286, 91);
         this->options_box->Name = L"options_box";
         this->options_box->Size = System::Drawing::Size(111, 95);
         this->options_box->TabIndex = 10;
         // 
         // listView1
         // 
         this->listView1->Columns->AddRange(gcnew cli::array< System::Windows::Forms::ColumnHeader^  >(2) { this->item_header, this->price_header });
         this->listView1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ListViewItem^  >(2) { listViewItem1, listViewItem2 });
         this->listView1->Location = System::Drawing::Point(422, 91);
         this->listView1->Name = L"listView1";
         this->listView1->Size = System::Drawing::Size(144, 97);
         this->listView1->Sorting = System::Windows::Forms::SortOrder::Descending;
         this->listView1->TabIndex = 13;
         this->listView1->UseCompatibleStateImageBehavior = false;
         this->listView1->View = System::Windows::Forms::View::Details;
         // 
         // item_header
         // 
         this->item_header->Text = L"Item";
         this->item_header->Width = 80;
         // 
         // price_header
         // 
         this->price_header->Text = L"Price";
         // 
         // items_lbl
         // 
         this->items_lbl->AutoSize = true;
         this->items_lbl->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
            static_cast<System::Byte>(0)));
         this->items_lbl->Location = System::Drawing::Point(150, 64);
         this->items_lbl->Name = L"items_lbl";
         this->items_lbl->Size = System::Drawing::Size(37, 13);
         this->items_lbl->TabIndex = 14;
         this->items_lbl->Text = L"Items";
         // 
         // items_cb
         // 
         this->items_cb->FormattingEnabled = true;
         this->items_cb->Items->AddRange(gcnew cli::array< System::Object^  >(1) { L"<New Item>" });
         this->items_cb->Location = System::Drawing::Point(153, 91);
         this->items_cb->Name = L"items_cb";
         this->items_cb->Size = System::Drawing::Size(111, 21);
         this->items_cb->TabIndex = 15;
         this->items_cb->Text = L"<Select Item>";
         this->items_cb->SelectedIndexChanged += gcnew System::EventHandler(this, &AdminHome::items_cb_SelectedIndexChanged);
         // 
         // addOption_btn
         // 
         this->addOption_btn->Location = System::Drawing::Point(286, 200);
         this->addOption_btn->Name = L"addOption_btn";
         this->addOption_btn->Size = System::Drawing::Size(75, 23);
         this->addOption_btn->TabIndex = 16;
         this->addOption_btn->Text = L"Add Option";
         this->addOption_btn->UseVisualStyleBackColor = true;
         this->addOption_btn->Visible = false;
         // 
         // addItem_btn
         // 
         this->addItem_btn->Location = System::Drawing::Point(189, 13);
         this->addItem_btn->Name = L"addItem_btn";
         this->addItem_btn->Size = System::Drawing::Size(61, 23);
         this->addItem_btn->TabIndex = 17;
         this->addItem_btn->Text = L"Add Item";
         this->addItem_btn->UseVisualStyleBackColor = true;
         this->addItem_btn->Visible = false;
         this->addItem_btn->Click += gcnew System::EventHandler(this, &AdminHome::addItem_btn_Click);
         // 
         // AdminHome
         // 
         this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
         this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
         this->ClientSize = System::Drawing::Size(596, 335);
         this->Controls->Add(this->addItem_btn);
         this->Controls->Add(this->addOption_btn);
         this->Controls->Add(this->items_cb);
         this->Controls->Add(this->items_lbl);
         this->Controls->Add(this->listView1);
         this->Controls->Add(this->options_box);
         this->Controls->Add(this->description_lbl);
         this->Controls->Add(this->textBox2);
         this->Controls->Add(this->label2);
         this->Controls->Add(this->label1);
         this->Controls->Add(this->category_cb);
         this->Controls->Add(this->itemName_txt);
         this->Controls->Add(this->Item_name_lbl);
         this->Controls->Add(this->done_btn);
         this->Controls->Add(this->exit_btn);
         this->Name = L"AdminHome";
         this->Text = L"AdminHome";
         this->ResumeLayout(false);
         this->PerformLayout();

      }

private: System::Void items_cb_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) {
   if (items_cb->SelectedItem->Equals("<New Item>"))
   {
      this->itemName_txt->Enabled = true;
      this->itemName_txt->Text = "Item Name";
      this->itemName_txt->Focus();
      this->addItem_btn->Visible = true;
   }
}
private: System::Void addItem_btn_Click(System::Object^  sender, System::EventArgs^  e) {
   this->items_cb->Items->Add(itemName_txt->Text);
   this->itemName_txt->Text = "";
   this->items_cb->SelectedIndex = 1;
   this->options_box->Focus();
   this->addOption_btn->Visible = true;
}
private: System::Void exit_btn_Click(System::Object^  sender, System::EventArgs^  e) {
   this->Close();
}
};
}
