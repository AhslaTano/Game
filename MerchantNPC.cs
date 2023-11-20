using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public abstract class MerchantNPC{
        public string _name;
        public string Name{get{return _name;} set{_name = value;}}
        public int _hp;
        public int HP{get{return _hp;} set{_hp = value;}}
        public int _gold;
        public int Gold{get{return _gold;} set{_gold = value;}}
        public bool hostile;
        public bool Hostile{get{return hostile;} set{hostile = value;}}

        public MerchantNPC(){
            _name = "";
            _hp = 0;
            _gold = 0;
            hostile = false;
        }
    }
}