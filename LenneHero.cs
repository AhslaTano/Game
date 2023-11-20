using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{
    public class LenneHero : Heroes{
        public LenneHero() : base(){
            _name = "Lenne";
            _hp = 200;
            _tp = 180;
            _magic = 10;
            _intelligence = 10;
            _crit = 2;
            _agility = 10;
            _defense = 10;
            _dmg = 10;
            _gold = 100;
            hostile = false;
            ability1Name = "Water Thrust";
            ability2Name = "Fire Thrust";
            ability3Name = "Wind Thrust";
            ability4Name = "Cleanse";
            items.Add("Daedalus Spear");
        }
        override
        public string ability1(Enemy target){
            _tp -= 30;
            dealDamage(target, 20);
            return "Lenne used: " + ability1Name;
        }
        override
        public string ability2(Enemy target){
            _tp -= 30;
            dealDamage(target, 20);
            return "Lenne used: " + ability2Name;
        }
        override
        public string ability3(Enemy target){
            _tp -= 30;
            dealDamage(target, 20);
            return "Lenne used: " + ability3Name;
        }
        override
        public string ability4(Enemy target){
            //removes one staus effect from a list?
            return "Lenne used: " + ability4Name;
        }
    }
}