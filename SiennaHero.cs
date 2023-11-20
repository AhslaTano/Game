using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{
    public class SiennaHero : Heroes{
        public SiennaHero() : base(){
            _name = "Sienna";
            _hp = 200;
            _tp = 160;
            _crit = 5;
            _agility = 30;
            _dmg = 10;
            _intelligence = 0;
            _magic = 0;
            _defense = 0;
            _gold = 100;
            ability1Name = "Yoko Girl";
            ability2Name = "Petal Storm";
            ability3Name = "X-Slash";
            ability4Name = "Pilfer";
        }
        override
        public string ability1(Enemy target){
            _tp -= 40;
            //Loop to search through the enemies in the room
            return "Sienna used: " + ability1Name;
        }
        override
        public string ability2(Enemy target){
            _tp -= 10;
            target._hp -= 50;
            return "Sienna used: " + ability2Name;
        }
        override
        public string ability3(Enemy target){
            _tp -= 20;
            target._hp -= 35;
            //Reactivate 20 dmg for 7 turns?
            return "Sienna used: " + ability3Name;
        }
        override
        public string ability4(Enemy target){
            string item = null;
            //Roll mechanic for chance
            Console.WriteLine("Choose an item to steal: ");
            for(int i = 0; i < target.items.Count; i++){
                Console.WriteLine(target.items.ElementAt(i));
            }
            try{
                while(item.Equals(null)){
                    item = Console.ReadLine();
                }
                target.items.Remove(item);
            }catch(IOException i){
                Console.WriteLine(i);
            }
            return "Sienna used: " + ability4Name;
        }
    }
}