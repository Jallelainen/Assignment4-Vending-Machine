using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_Vending_Machine.VendingMachine
{
    interface IVM
    {
        void InsertMoney(int userChoice);//user puts the money in the machine
        Product PickProduct();//user picks the product(s) they want to buy
        int GetCredit();//show how much money/credits the user has put in
        Product[] FinishPurchase();//user finishes their purchase and gets products and change

        int CalculateChange();
    }
}
