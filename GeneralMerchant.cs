using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class GeneralMerchant : MerchantNPC{
        public GeneralMerchant() : base(){
            _name = "General Merchant";
            _hp = 100;
            _gold = 1000;
            hostile = false;
        }
        public void GeneralMerchantWelcome(){
            Console.WriteLine("Hello there, Heroes of Valandis! Would you like to buy any general goods?");
        }
        public void GeneralMerchantDepart(){
            Console.WriteLine("Well then, Good bye, Heroes! Good luck on your Adventures!");
        }
        public void GeneralMerchantInventory(){
            ArrayList GeneralMerchItems = new ArrayList();

            Item Snacks = new Item("Snacks", 0, 10);
            Item AngelWings = new Item("Angel Wings", 0, 20);

            GeneralMerchItems.Add(Snacks);
            GeneralMerchItems.Add(AngelWings);
        }
    }
}