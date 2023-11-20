using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{
    public abstract class Heroes : NPC{
        public string ability1Name;
        public string ability2Name;
        public string ability3Name;
        public string ability4Name;
        public Heroes(){
            _name = "";
            _hp = 0;
            _tp = 0;
            _magic = 0;
            _intelligence = 0;
            _crit = 0;
            _agility = 0;
            _defense = 0;
            _dmg = 0;
            _gold = 0;
            ability1Name = "";
            ability2Name = "";
            ability3Name = "";
            ability4Name = "";
            hostile = false;
        }
        public abstract string ability1(Enemy target);
        public abstract string ability2(Enemy target);
        public abstract string ability3(Enemy target);
        public abstract string ability4(Enemy target);
        public void death(Player player){
            player.NormalMessage(Name + "has died. Can be revived!");
        }
        public void attack(Enemy target, Item item){
            target.HP -= item.Damage;
        }
    }
}