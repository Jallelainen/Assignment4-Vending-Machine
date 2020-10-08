using System;
using System.Collections.Generic;
using System.Text;
using Assignment4_Vending_Machine.VendingMachine;

namespace Assignment4_Vending_Machine.VendingMachine
{
    public abstract class Product
    {
        int id = 0;

        public string Name { get; set; }
        public int Price { get; set; }
        public int Id { get { return id; } set { } }


        public Product(string name, int price)
        {
            Id = Id++;
            Name = name;
            Price = price;
        }

        public bool Purchase(Product product, VM vm)
        {
            bool canAfford;
            int moneyPool = vm.GetCredit();

            if (moneyPool >= product.Price)
            {
                canAfford = true;
            }
            else
            {
                canAfford = false;
            }

            return canAfford;
        }

        public abstract string Use();

        public abstract string Examine();

    }
}
