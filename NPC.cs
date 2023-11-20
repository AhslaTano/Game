using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public abstract class NPC{
        public string _name;
        public string Name{get{return _name;} set{_name = value;}}
        public int _hp;
        public int HP{get{return _hp;} set{_hp = value;}}
        public int _tp;
        public int TP{get{return _tp;} set{_tp = value;}}
        public double _magic;
        public double Magic{get{return _magic;} set{_magic = value;}}
        public double _intelligence;
        public double Intelligence{get{return _intelligence;} set{_intelligence = value;}}
        public double _crit;
        public double Crit{get{return _crit;} set{_crit = value;}}
        public double _agility;
        public double Agility{get{return _agility;} set{_agility = value;}}
        public double _defense;
        public double Defense{get{return _defense;} set{_defense = value;}}
        public double _dmg;
        public double Dmg{get{return _dmg;} set{_dmg = value;}}
        public int _gold;
        public int Gold{get{return _gold;} set{_gold = value;}}
        public bool hostile;
        public bool Hostile{get{return hostile;} set{hostile = value;}}
        public List<String> items = new List<String>();
        public NPC(){
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
            hostile = false;
        }
    }
}