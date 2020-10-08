using System;
using System.Collections.Generic;
using System.Text;
using Assignment4_Vending_Machine.VendingMachine;

namespace Assignment4_Vending_Machine.VendingMachine
{
    public abstract class Product
    {
        int id = 0;

        string Name { get; set; } 
        int Price { get; set; }
        int Id { get { return id; } set { } }


        public Product(string name, int price)
        {
            Id = Id++;
            Name = name;
            Price = price;
        }

        public Product[] Purchase(Product product)
        {
            Product[] boughtProducts = new Product[0];
            VM vm = new VM();
            int moneyPool = vm.GetCredit();

            if (moneyPool >= product.Price)
            {
                Array.Resize(ref boughtProducts, boughtProducts.Length + 1);
                boughtProducts[boughtProducts.Length - 1] = product;

            }
            else
            {
                throw new Exception("You do not have enough credits to buy this product.");
            }

            return boughtProducts;
        }

        public abstract void Use();

    }
}
