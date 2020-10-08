using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_Vending_Machine.VendingMachine
{
    class Readables : Product
    {
        string Info { get; set; }
        string Usage { get; set; }

        public Readables(string name, int price, string info, string use) : base(name, price)
        {
            Info = info;
            Usage = use;
        }

        public override void Use()
        {
            throw new NotImplementedException();
        }
    }
}
