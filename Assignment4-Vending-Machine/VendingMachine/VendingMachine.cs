using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_Vending_Machine.VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        int[] moneyDenominator = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        int moneyPool;
        Product userPick;
        Product[] boughtProducts = new Product[0];


        public int GetCredit()
        {
            return moneyPool;
        }

        public void InsertMoney(int userChoice)
        {
            moneyPool = moneyDenominator[userChoice];

            GetCredit();
        }

        public Product PickProduct()
        {
            throw new NotImplementedException();
        }

        Product[] IVendingMachine.FinishPurchase()
        {
            throw new NotImplementedException();
        }
    }
}
