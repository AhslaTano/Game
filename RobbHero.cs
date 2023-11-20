using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{
    public class RobbHero : Heroes{
        public RobbHero() : base(){
            _name = "Robb";
            _hp = 180;
            _tp = 220;
            _magic = 10;
            _intelligence = 60;
            _crit = 0;
            _defense = 0;
            _dmg = 0;
            _gold = 100;
            _agility = 0;
            ability1Name = "Poison Shot";
            ability2Name = "Power Shot";
            ability3Name = "Herbal Medicine";
            ability4Name = "Ailment Trap";
        }
        override
        public string ability1(Enemy target){
            return "Robb used: " + ability1Name;
        }
        override
        public string ability2(Enemy target){
            return "Robb used: " + ability2Name;
        }
        override
        public string ability3(Enemy target){
            return "Robb used: " + ability3Name;
        }
        override
        public string ability4(Enemy target){
            return "Robb used: " + ability4Name;
        }
    }
}