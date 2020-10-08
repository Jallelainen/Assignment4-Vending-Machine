using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_Vending_Machine.VendingMachine
{
    public class VM : IVM
    {
        int[] moneyDenominator = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        int moneyPool = 0;
        Product userPick;

        public VM()
        {
            int MoneyPool = moneyPool;
            Product[] pickedProducts = new Product[0];
            Product[] productArr = new Product[8];

            productArr[0] = new Edibles("Shinji Ramen Noodles", 15, "Spicy flavored ramen noodles made in Japan.", "cook the noodles in boiling water then eat them.");
            productArr[1] = new Edibles("Power Bar", 35, "Nutritional snack with granola, müsli and chocolate. Perfect for when you need that extra boost", "unwrap the power bar then eat it.");
            productArr[2] = new Edibles("Granny Bacons Chocolate flavored Crisps", 39, "Chocolate flavored crisps that combines the sensations of salt and sweet. Granny Bacons original recepie, try them today!", "open the bag and eat the crisps with your hand.");
            productArr[3] = new Drinkables("Super Sugar Ray", 22, "Fizzy drink with an awesome sugar flavor. New recepie with added sugar! From the good folks at Nestlé.", "unscrew the cork and drink straight from the bottle.");
            productArr[4] = new Drinkables("Spring Water Naturals", 31, "Exclusive water flavored water with minerals from the springs of the Hudson river, NYC.", "open the cap with a capopener and pour into a glas, then drink from said glas.");
            productArr[5] = new Drinkables("Nuka-Cola", 19, "Classic Nuka-Cola in a glass bottle. The perfect blend of ingridients that brings in the sweet in life.", "unscrew the cork and chug the whole bottle faster than you can say hiccups.");
            productArr[6] = new Readables("FizzFeed News Weekly #71", 68, "Your primary source of what is happening in the glamourous lives of celebrities all around the world. This week: Gwyneth Paltrow bought a pig as a finacial supervisor.", "open the magazine and feel your brain melt.");
            productArr[7] = new Readables("Bros 'n' Cars #44", 54, "The ONLY weekly dose of adrenaline and gasoline, with classy pictures of all the things you like: cars, gals, weapons and more..", "turn the pages, looking at the pictures occasionaly reading a word here and there.");

        }


        public int CalculateChange()
        {
            throw new NotImplementedException();
        }

        public int GetCredit()
        {
            return moneyPool;
        }

        public void InsertMoney(int userChoice)
        {
            moneyPool = moneyPool + moneyDenominator[userChoice];

            GetCredit();
        }

        public Product PickProduct()
        {
            throw new NotImplementedException();
        }

        Product[] IVM.FinishPurchase()
        {
            throw new NotImplementedException();
        }
    }
}
