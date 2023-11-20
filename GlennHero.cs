using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{
    public class GlennHero : Heroes{
        public GlennHero() : base(){
            _name = "Glenn";
            _hp = 220;
            _tp = 200;
            _intelligence = 10;
            _crit = 2;
            _defense = 20;
            _dmg = 20;
            _agility = 0;
            _magic = 0;
            _gold = 100;
            ability1Name = "Cross Slash";
            ability2Name = "Fire Strike";
            ability3Name = "Armor Break";
            ability4Name = "Lend Energy";
        }
        override
        public string ability1(Enemy enemy){
            return "Glenn used: " + ability1Name;
        }
        override
        public string ability2(Enemy enemy){
            return "Glenn used: " + ability2Name;
        }
        override
        public string ability3(Enemy enemy){
            return "Glenn used: " + ability3Name;
        }
        override
        public string ability4(Enemy enemy){
            return "Glenn used: " + ability4Name;
        }
    }
}