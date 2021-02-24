﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 

namespace RestaurantKiosk
{
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
   [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
   public partial class Items
   {

      private List<MenuItem> itemsList = new List<MenuItem>();

      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("MenuItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      public List<MenuItem> ItemsList
      {
         get
         {
            return this.itemsList;
         }
         set
         {
            this.itemsList = value;
         }
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
   public partial class MenuItem
   {

      private List<Option> options = new List<Option>();

      private string name;

      private string category;

      private int calories;

      private string description;

      private float price;

      private float timeCost;

      private bool available;

      private string uniqueID;

      /// <remarks/>
      [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
      [System.Xml.Serialization.XmlArrayItemAttribute("Option", typeof(Option), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
      public List<Option> Options
      {
         get
         {
            return this.options;
         }
         set
         {
            this.options = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string nameAtt
      {
         get
         {
            return this.name;
         }
         set
         {
            this.name = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string categoryAtt
      {
         get
         {
            return this.category;
         }
         set
         {
            this.category = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int caloriesAtt
      {
         get
         {
            return this.calories;
         }
         set
         {
            this.calories = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string descriptionAtt
      {
         get
         {
            return this.description;
         }
         set
         {
            this.description = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public float priceAtt
      {
         get
         {
            return this.price;
         }
         set
         {
            this.price = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public float timeCostAtt
      {
         get
         {
            return this.timeCost;
         }
         set
         {
            this.timeCost = value;
         }
      }

      [XmlIgnore]
      public string uniqueIDAtt
      {
         get
         {
            return this.uniqueID;
         }
         set
         {
            this.uniqueID = value;
         }
      }

      public MenuItem()
      {

      }

      public MenuItem(int cal, string desc, string itemName, float itemPrice, float itemTimeCost, string categoryName)
      {
         calories = cal;
         description = desc;
         name = itemName;
         price = itemPrice;
         timeCost = itemTimeCost;
         available = true;
         options = new List<Option>();
         category = categoryName;
      }

      public void addOption(Option newOption)
      {
         options.Add(newOption);
      }

      public void removeOption(int index)
      {
         options.RemoveAt(index);
      }

      public void updatetimeCost(float newTime)
      {
         timeCost = newTime;
      }

      public Option getOption(string name)
      {
         foreach (Option option in options)
         {
            if (option.nameAtt.Equals(name))
            {
               return options.Find(x => x.nameAtt == name);
            }
         }
         return null;
      }

      public int getOptionsListSize()
      {
         return options.Count;
      }

      public void updateCategory(string newCat)
      {
         category = newCat;
      }
   }

   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
   public partial class Option
   {

      private string name;

      private string picture;

      private float price;

      private int addedCalories;

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string nameAtt
      {
         get
         {
            return this.name;
         }
         set
         {
            this.name = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string pictureAtt
      {
         get
         {
            return this.picture;
         }
         set
         {
            this.picture = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public float priceAtt
      {
         get
         {
            return this.price;
         }
         set
         {
            this.price = value;
         }
      }

      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public int addedCaloriesAtt
      {
         get
         {
            return this.addedCalories;
         }
         set
         {
            this.addedCalories = value;
         }
      }

      public Option()
      {

      }

      public Option(string optionName, float optionPrice, int cal)
      {
         name = optionName;
         price = optionPrice;
         addedCalories = cal;
      }
   }
}
