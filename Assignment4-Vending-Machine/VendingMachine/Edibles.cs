using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_Vending_Machine.VendingMachine
{
    public class Edibles : Product
    {
        //string name = "Shinji Ramen";
        //string info = "Premium Ramen Noodles from the shores of Japan. Spicy flavored instant noodles, just add water.";
        //string useMessage = "After peeling off the plastic wrapping you take a bite of this soft boiled piece of perfection. " +
        //    "Before you know it, the whole egg is gone and you realize that pleasure sure is fleeting";
        //int price = 10;
        string Info { get; set; }
        string Usage { get; set; }


        public Edibles(string name, int price, string info, string use) : base(name, price)
        {
            Info = info;
            Usage = use;
        }

        public override void Use()
        {
            
        }
    }
}
