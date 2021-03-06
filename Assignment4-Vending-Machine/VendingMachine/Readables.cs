﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_Vending_Machine.VendingMachine
{
    class Readables : Product
    {
        string Info { get; set; }
        string Usage { get; set; }

        //derived class constructor with added variables
        public Readables(string name, int price, string info, string use) : base(name, price)
        {
            Info = info;
            Usage = use;
        }

        //overridden methods from base class. specialized to fit this class.
        public override string Use()
        {
            return $"After recieving the {Name} magazine from the vending machine you {Usage}";
        }

        public override string Examine()
        {
            return $"While you examine your {Name} magazine you decide to take a moment to read its description. It reads: {Info}";
        }
    }
}
