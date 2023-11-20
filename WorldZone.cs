using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public abstract class WorldZone{
        private string zone;
        public List<Room> _rooms;
        public string Zone{ get {return zone;} set {zone = value;}}
        public WorldZone(){
            zone = "";
            _rooms = new List<Room>();
        }

        public abstract void CreateZone();
    }
}