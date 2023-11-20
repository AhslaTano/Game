using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class ArmorMerchant: MerchantNPC{
        public ArmorMerchant() : base(){
            _name = "Armor Merchant";
            _hp = 100;
            _gold = 1000;
            hostile = false;
        }
        public void ArmorMerchantWelcome(){
            Console.WriteLine("Hello there, Heroes of Valandis! Would you like to buy any armor sets for your adventures throughout Valandis?");
        }
        public void ArmorMerchantDepart(){
            Console.WriteLine("Well then, Good bye, Heroes! Good luck on your Adventures!");
        }
        public void ArmorMerchItems(){
            ArrayList ArmorMerchItems = new ArrayList();

            Item MercilessDarkSilverArmor = new Item("Merciless Dark Silver Armor", 0, 200);
            Item SanguineArmor = new Item("Sanguine Armor", 0, 300);
            Item IronArmor = new Item("Iron Armor", 0, 100);
            Item MercilessIronArmor = new Item("Merciless Iron Armor", 0, 200);
            Item PaddedArmor = new Item("Padded Armor", 0, 150);
            Item FenrisArmor = new Item("Fenris Armor", 0, 200);
            Item SilverArmor = new Item("Silver Armor", 0, 150);

            ArmorMerchItems.Add(MercilessDarkSilverArmor);
            ArmorMerchItems.Add(SanguineArmor);
            ArmorMerchItems.Add(IronArmor);
            ArmorMerchItems.Add(MercilessIronArmor);
            ArmorMerchItems.Add(PaddedArmor);
            ArmorMerchItems.Add(FenrisArmor);
            ArmorMerchItems.Add(SilverArmor);
        }
    }
}