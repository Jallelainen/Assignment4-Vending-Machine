using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_Vending_Machine.VendingMachine
{
    public class Edibles : Product
    {
        string Info { get; set; }
        string Usage { get; set; }


        public Edibles(string name, int price, string info, string use) : base(name, price)
        {
            Info = info;
            Usage = use;
        }

        public override string Use()
        {
            return $"After recieving the {Name} from the vending machine you {Usage}";
        }

        public override string Examine()
        {
            throw new NotImplementedException();
        }
    }
}
