using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_Vending_Machine.VendingMachine
{
    public abstract class Product
    {
        string Name { get; set;  }
        string Info { get; set; }
        int Price { get; set; }

        Product[] productArr = new Product[8];

        public Product(string name, string info, int price)
        {
            Name = name;
            Info = info;
            Price = price;
        }

        public void Purchase()
        {

        }

        public void Use()
        {

        }

    }
}
