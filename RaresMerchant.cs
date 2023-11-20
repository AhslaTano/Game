using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class RaresMerchant : MerchantNPC{
        public RaresMerchant() : base(){
            _name = "Rares Merchant";
            _hp = 100;
            _gold = 1000;
            hostile = false;
        }
        public void RaresMerchantWelcome(){
            Console.WriteLine("Hello there, Heroes of Valandis! Would you like to buy any rare items so rare they can only be found here?");
        }
        public void RaresMerchantDepart(){
            Console.WriteLine("Well then, Good bye, Heroes! Good luck on your Adventures!");
        }
        public void RaresMerchantInventory(){
            ArrayList RaresMerchItems = new ArrayList();

            Item SanguineSword = new Item("Sanguine Sword", 40, 200);
            Item MercilessDarkSilverSpear = new Item("Merciless Dark Silver Spear", 35, 150);
            Item MercilessDarkSilverKatana = new Item("Merciless Dark Silver Katana", 35, 120);
            Item SanguineBow = new Item("Sanguine Bow", 30, 200);
            Item SanguineSpear = new Item("Sanguine Spear", 35, 200);
            Item MercilessIronSword = new Item("Merciless Iron Sword", 25, 100);

            RaresMerchItems.Add(SanguineSword);
            RaresMerchItems.Add(MercilessDarkSilverSpear);
            RaresMerchItems.Add(MercilessDarkSilverKatana);
            RaresMerchItems.Add(SanguineBow);
            RaresMerchItems.Add(SanguineSpear);
            RaresMerchItems.Add(MercilessIronSword);
        }
    }
}