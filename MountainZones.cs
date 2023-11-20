using System;
using System.Collections;
using System.Collections.Generic;

namespace EchoesOfValandis{

    public class MountainZones : WorldZone{
        public MountainZones() : base(){
            this.Zone = "Mountains";
            this._rooms = new List<Room>();
        }
        override
        public void CreateZone(){
            Room MountainsEntry = new Room("Valandis Mountains Entry Zone: Nothing present here");
            Room MountainsPylon = new Room("Valandis Mountains Teleport Pylon");
            Room MountainsNorth1 = new Room("Valandis Mountains North: Level 1: Enemies: 4 Drakelings");
            Room MountainsNorth2 = new Room("Valandis Mountains North: Boss: Moder");
            Room MountainsSouth = new Room("Valandis Mountains South: 2 Wolves, 1 Drakeling, 1 Frost Skeleton");
            Room MountainsEast = new Room("Valandis Mountains East: 2 Wolves, 2 Drakelings");
            Room MountainsWest = new Room("Valandis Mountains West: 2 Wolves, 2 Drakelings");

            MountainsEntry.SetExit("North", MountainsNorth1);
            MountainsEntry.SetExit("South", MountainsSouth);
            MountainsEntry.SetExit("East", MountainsEast);
            MountainsEntry.SetExit("West", MountainsWest);
            MountainsEntry.SetExit("MountainPylon", MountainsPylon);

            MountainsNorth1.SetExit("North", MountainsNorth2);
            MountainsNorth1.SetExit("South", MountainsEntry);
            MountainsNorth2.SetExit("South", MountainsNorth1);

            MountainsSouth.SetExit("North", MountainsEntry);

            MountainsEast.SetExit("West", MountainsEntry);
            
            MountainsWest.SetExit("East", MountainsEntry);

            MountainsPylon.SetExit("MountainEntry", MountainsEntry);

            _rooms.Add(MountainsEntry);
            _rooms.Add(MountainsPylon);
            _rooms.Add(MountainsNorth1);
            _rooms.Add(MountainsNorth2);
            _rooms.Add(MountainsSouth);
            _rooms.Add(MountainsEast);
            _rooms.Add(MountainsWest);
        }
    }
}