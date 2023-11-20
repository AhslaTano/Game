using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{
    public class Item{
        private string _name;
        private int _damage;
        private int _sellPrice;

        public Item(string name, int damage, int sellPrice){
            _name = name;
            _damage = damage;
            _sellPrice = sellPrice;
        }
        public string Name{get{return _name;} set{_name = value;}}
        public int Damage{get{return _damage;} set{_damage = value;}}
        public int SellPrice{get{return _sellPrice;} set{_sellPrice = value;}}
    }
}