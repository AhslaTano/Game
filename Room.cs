using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{
    public class Room{
        private Dictionary<string, Room> exits;
        private string tag;
        public string Tag{get{return tag;} set{tag = value;}}
        public Room() : this("No tag"){}
        public Room(string tag){
            this.tag = tag;
            exits = new Dictionary<string, Room>();
        }
        public void SetExit(string exitName, Room room){
            exits[exitName] = room;
        }
        public Room GetExit(string exitName){
            Room room = null;
            exits.TryGetValue(exitName, out room);
            return room;
        }
        public String Showexits(){
            string roomExits = "You see exits: ";
            Dictionary<string, Room>.KeyCollection keys = exits.Keys;
            foreach(string exitName in keys){
                roomExits += "" + exitName;
            } 
            return roomExits;
        }
        public String Description(){
            return "You are in " + this.Tag + "\n" + Showexits();
        }
    }
}