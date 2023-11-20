using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class WeaponsMerchant: MerchantNPC{
        public WeaponsMerchant() : base(){
            _name = "Weapons Merchant";
            _hp = 100;
            _gold = 1000;
            hostile = false;
        }
        public void WeaponsMerchantWelcome(){
            Console.WriteLine("Hello there, Heroes of Valandis! Would you like to buy any weapons for your grand adventures throughout Valandis?");
        }
        public void WeaponsMerchantDepart(){
            Console.WriteLine("Well then, Good bye, Heroes! Good luck on your Adventures!");
        }
        public void WeaponsMerchItems(){
            ArrayList WeaponsMerchItems = new ArrayList();

            Item SilverSword = new Item("Silver Sword", 30, 100);
            Item VikingSword = new Item("Viking Sword", 20, 55);
            Item IronSpear = new Item("Iron Spear", 25, 60);
            Item DarkSilverSpear = new Item("Dark Silver Spear", 30, 100);
            Item IronKatana = new Item("Iron Katana", 25, 60);
            Item VikingKatana = new Item("Viking Katana", 20, 55);

            WeaponsMerchItems.Add(SilverSword);
            WeaponsMerchItems.Add(VikingSword);
            WeaponsMerchItems.Add(IronSpear);
            WeaponsMerchItems.Add(DarkSilverSpear);
            WeaponsMerchItems.Add(IronKatana);
            WeaponsMerchItems.Add(VikingKatana);
        }
    }
}