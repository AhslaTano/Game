using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{
    public class Enemy : NPC{
        public Enemy(string name, int hp, double magic, double crit, double ag, double def, double dmg, int gold){
            _name = name;
            _hp = hp;
            _magic = magic;
            _crit = crit;
            _agility = ag;
            _dmg = dmg;
            _gold = gold;
            hostile = true;
        }
    }
}