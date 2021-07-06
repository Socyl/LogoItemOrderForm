using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoItemOrderForm
{
    class LogoOrderItem
    {

        //BACKING VARIABLES
        private bool hasLogo;
        private string itemType;
        private int numColors;
        private int numItems;
        private string text;

        //CONSTRUCTORS

        //6 parameter 
        public LogoOrderItem(bool newHasLogo, string newItemType, 
                            int newNumColors, int newNumItems,
                            string newText, int newItemID)
        {
            HasLogo = newHasLogo;
            ItemType = newItemType;
            NumColors = newNumColors;
            NumItems = newNumItems;
            Text = newText;
            ItemID = newItemID;
        }
        //2 parameter(hasLogo, text)
        public LogoOrderItem(bool newHasLogo, string newText)
            :this(newHasLogo, "mug", 0, 0, newText, -1)
        {

        }
        //default(no parameters)
        public LogoOrderItem()
            :this(false, "mug",0,0,"",-1)
        {

        }


        //PROPERTIES
        public int OrderID { get; set; }

        public int ItemID { get; set; }

        public decimal TotalPrice { get; private set; }

        public bool HasLogo
        {
            get
            {
                return hasLogo;
            }
            set
            {
                hasLogo = value;
                Calc();
            }
        }

        public string ItemType
        {
            get
            {
                return itemType;
            }
            set
            {
                itemType = value;
                Calc();
            }
        }

        public int NumColors
        {
            get
            {
                return numColors;
            }
            set
            {
                numColors = value;
                Calc();
            }
        }

        public int NumItems
        {
            get
            {
                return numItems;
            }
            set
            {
                numItems = value;
                Calc();
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                Calc();
            }
        }

        //METHODS
        private void Calc()
        {
            TotalPrice = 0;
            //basic item prices
            if (NumItems == 0)  //dont bother to calc until number of items is set.
            {
                return;
            }

            //charge for basic ItemType
            if (string.Equals(ItemType, "USB stick"))
            {
                TotalPrice += 4.0M * NumItems;
            }
            else if (string.Equals(ItemType, "mug"))
            {
                TotalPrice += 3.5M * NumItems;
            }
            else if (string.Equals(ItemType, "pen"))
            {
                TotalPrice += 1.0M * NumItems;
            }
        

            //charge if text to be engraved
            if (!(string.Equals(Text, "")))
            {
                TotalPrice += .05M * NumItems;
            }
            //charge if  logo involved
            if (HasLogo)
            {
                TotalPrice += .1M * NumItems;
                TotalPrice += .03M * NumItems * NumColors;
            }
        }

        public string GetOrderSummary()
        {
            string result = "Order number " + OrderID + ": " + NumItems + " " + ItemType+"s";

            if (HasLogo)
            {
                result += " with " + NumColors + " color logo";
            }
            if (!(string.Equals(Text, ""))) 
            {
                result += " with the following text: " + Text;
            }
            result += "! Price: $" + TotalPrice;

            return result;                 
        }
    }
}
