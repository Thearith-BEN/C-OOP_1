using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Products
    {
        // Data member / Field / Properties
        private string itemname;
        private int qty;
        private double price;

        // Method / Event
            // Constructor
        public Products()
        {
            itemname = "Coke";
            qty = 10;
            price = 70;
        }
        public Products( string name, int q, double price)
        {
            itemname = name;
            qty = q;
            this.price = price;
        }

        //Setter
        public void SetItemName( string name )
        {
            this.itemname = name;
        }
        public void SetQty(int q)
        {
            this.qty = q;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }

        // Getter
        public string GetItemName()
        {
            return this.itemname;
        }
        public int GetQty()
        {
            return this.qty;
        }
        public double GetPrice()
        {
            return this.price;
        }

        // ToString()



    }
}
